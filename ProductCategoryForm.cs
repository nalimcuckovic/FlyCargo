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
    public partial class ProductCategoryForm : Form
    {
        private readonly IProductCategoryRepository _productCategoryRepository;
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        private readonly AppDbContext _context;

        public ProductCategoryForm(IProductCategoryRepository productCategoryRepository, IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            InitializeComponent();
            _productCategoryRepository = productCategoryRepository;
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;

            this.Load += ProductCategoryForm_Load; // Registruj Load događaj
        }

        private void SetupDataGridView()
        {
            dgvProductCategories.Columns.Clear();
        }


        private async Task LoadProductCategories()
        {
            var productCategories = await _productCategoryRepository.GetAllProductCategoriesAsync();

            var result = productCategories.Select(pc => new
            {
                pc.ProductId,
                ProductName = pc.Product.ProductName, // Koristi naziv proizvoda
                pc.CategoryId,
                CategoryName = pc.Category.CategoryName // Koristi naziv kategorije
            }).ToList();

            dgvProductCategories.DataSource = result;
        }



        private async void ProductCategoryForm_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            await LoadProductCategories();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=FlyCargo;Trusted_Connection=True;");

            using (var context = new AppDbContext(optionsBuilder.Options))
            {
                ICategoryRepository categoryRepository = new CategoryRepository(context);

                IProductRepository productRepository = new ProductRepository(context);

                AddProductCategories addProductCategoriesForm = new AddProductCategories(productRepository, categoryRepository, _productCategoryRepository);

                if (addProductCategoriesForm.ShowDialog() == DialogResult.OK)
                {
                    LoadProductCategories();
                }
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProductCategories.SelectedRows.Count > 0)
            {
                var selectedRow = dgvProductCategories.SelectedRows[0];
                int productId = (int)selectedRow.Cells["ProductId"].Value;
                int categoryId = (int)selectedRow.Cells["CategoryId"].Value;

                var productCategory = await _productCategoryRepository.GetProductCategoryAsync(productId, categoryId);

                if (productCategory != null)
                {
                    // Učitaj podatke za uređivanje u AddProductCategories formi
                    var editForm = new AddProductCategories(_productRepository, _categoryRepository, _productCategoryRepository, productCategory);

                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        await LoadProductCategories(); // Ponovo učitaj podatke nakon uređivanja
                    }
                }
                else
                {
                    MessageBox.Show("Product category not found.");
                }
            }
            else
            {
                MessageBox.Show("Please select a product category to edit.");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            // Provera da li je red u DataGridView selektovan
            if (dgvProductCategories.SelectedRows.Count > 0)
            {
                // Dobijanje selektovanog reda
                var selectedRow = dgvProductCategories.SelectedRows[0];

                // Pretpostavka: ProductId i CategoryId su kolone u DataGridView
                var productId = (int)selectedRow.Cells["ProductId"].Value;
                var categoryId = (int)selectedRow.Cells["CategoryId"].Value;

                // Pitanje korisniku da li želi da obriše zapis
                var confirmResult = MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj zapis?", "Potvrda brisanja", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    // Brisanje veze
                    await _productCategoryRepository.DeleteProductCategoryAsync(productId, categoryId);
                    MessageBox.Show("Veza između proizvoda i kategorije je uspešno obrisana.");

                    LoadProductCategories();
                }
            }
            else
            {
                MessageBox.Show("Molimo izaberite red za brisanje!");
            }
        }

    }

}
