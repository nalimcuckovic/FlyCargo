using FlyCargo.Models.Data;
using FlyCargo.Models.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyCargo.GUI
{
    public partial class ProductForm : Form
    {
        private readonly IProductRepository _productRepository;

        private readonly AppDbContext _context;
        private int? selectedProductId = null;

        public ProductForm(IProductRepository productRepository)
        {
            InitializeComponent();
            _productRepository = productRepository;
            _context = new AppDbContext();


            this.Load += ProductForm_Load;
        }

        private async void ProductForm_Load(object sender, EventArgs e)
        {
            dgvProducts.Columns.Clear();
            await LoadProductsAsync(_context);
        }

        private async Task LoadProductsAsync(AppDbContext _context, string sSearchByName = null)
        {
            try
            {
                _context = new AppDbContext();
                await _context.Products.LoadAsync(); // Koristi await za asinkrono učitavanje podataka

                var productsQuery = _context.Products.AsQueryable();

                // Ako je prosleđen parametar sSearchByName, filtriraj proizvode po nazivu
                if (!string.IsNullOrEmpty(sSearchByName))
                {
                    productsQuery = productsQuery.Where(p => p.ProductName.Contains(sSearchByName));
                }

                var products = await productsQuery.ToListAsync();

                // Postavi podatke u DataGridView
                dgvProducts.DataSource = products.Select(p => new
                {
                    p.ProductId,
                    p.ProductName,
                    p.CreatedAt,
                    p.Description,
                    p.Price,
                    p.StockQuantity
                }).ToList();

                dgvProducts.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
         

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            string sProductName = tbProductName.Text;
            string sProductDescription = tbProductDescription.Text;
            int iStockQuantity = Convert.ToInt32(nudProductStockQuantity.Value);

            decimal? dProductPrice = null;
            if (!String.IsNullOrEmpty(tbProductPrice.Text))
            {
                dProductPrice = Convert.ToDecimal(tbProductPrice.Text);
            }

            DateTime dtCreatedAt = dtpProductCreated.Value;

            if (string.IsNullOrWhiteSpace(sProductName))
            {
                MessageBox.Show("You did not input a product name!");
                return;
            }

            ProductRepository productRepository = new ProductRepository(_context);

            if (selectedProductId.HasValue)
            {
                Product productToUpdate = await productRepository.GetProductById(selectedProductId.Value);

                if (productToUpdate != null)
                {
                    productToUpdate.ProductName = sProductName;
                    productToUpdate.CreatedAt = dtCreatedAt;
                    productToUpdate.StockQuantity = iStockQuantity;
                    productToUpdate.Price = dProductPrice;
                    productToUpdate.Description = sProductDescription;

                    await productRepository.UpdateProduct(productToUpdate);
                }
            }
            else
            {
                Product newProducts = new Product
                {
                    ProductName = sProductName,
                    CreatedAt = dtCreatedAt,
                    StockQuantity = iStockQuantity,
                    Price = dProductPrice,
                    Description = sProductDescription,
                };

                await productRepository.AddProduct(newProducts);
            }

            ProductForm_Load(sender, e);
            tbProductName.Text = string.Empty;
            tbProductPrice.Text = string.Empty;
            tbProductDescription.Text = string.Empty;
            dtpProductCreated.Value = DateTime.Now;
            nudProductStockQuantity.Value = 1;
        }

        private void tbProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.' || e.KeyChar == ',') && (sender as TextBox).Text.Contains(".") || (sender as TextBox).Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void dgvProducts_DoubleClick(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null)
            {
                selectedProductId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["ProductId"].Value);
                string selectedProductName = dgvProducts.CurrentRow.Cells["ProductName"].Value.ToString();
                string selectedProductDescription = dgvProducts.CurrentRow.Cells["Description"].Value.ToString();
                int? iProductStockQuantity = Convert.ToInt32(dgvProducts.CurrentRow.Cells["StockQuantity"].Value.ToString());
                decimal? dProductPrice = Convert.ToDecimal(dgvProducts.CurrentRow.Cells["Price"].Value.ToString());
                DateTime selectedCreatedAt = Convert.ToDateTime(dgvProducts.CurrentRow.Cells["CreatedAt"].Value);

                tbProductName.Text = selectedProductName;
                dtpProductCreated.Value = selectedCreatedAt;
                tbProductDescription.Text = selectedProductDescription;
                nudProductStockQuantity.Value = iProductStockQuantity.Value;
                tbProductPrice.Text = dProductPrice.Value.ToString();
            }
            else
            {
                MessageBox.Show("You did not double click grid view!");
                return;
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string sSearchByName = tbSearchByName.Text;
            if (String.IsNullOrEmpty(sSearchByName) || sSearchByName.Count() < 1)
            {
                MessageBox.Show("For search product, you must input min. 2 chars!");
                return;
            }

            await LoadProductsAsync(_context, sSearchByName);
        } 

        private async void cbClearSearch_CheckedChanged(object sender, EventArgs e)
        {
            string sSearchByName = tbSearchByName.Text;
            if (!String.IsNullOrEmpty(sSearchByName))
            {
                tbSearchByName.Text = String.Empty;
                await LoadProductsAsync(_context);
            }
        }
    }
}
