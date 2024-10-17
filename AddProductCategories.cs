using FlyCargo.Models.Data;
using FlyCargo.Models.Repositories;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FlyCargo.GUI
{
    public partial class AddProductCategories : Form
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IProductCategoryRepository _productCategoryRepository;

        public AddProductCategories(IProductRepository productRepository, ICategoryRepository categoryRepository, IProductCategoryRepository productCategoryRepository, ProductCategory productCategory = null)
        {
            InitializeComponent();
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _productCategoryRepository = productCategoryRepository;

            // Poziv asinhrone metode unutar konstruktora
            LoadFormData(productCategory);
        }

        private async void LoadFormData(ProductCategory productCategory)
        {
            await LoadData();

            if (productCategory != null)
            {
                var categoryItem = cbCategories.Items.Cast<ComboBoxItem>().FirstOrDefault(x => x.Id == productCategory.CategoryId);
                if (categoryItem != null)
                {
                    cbCategories.SelectedItem = categoryItem;
                }

                var productItem = cbProducts.Items.Cast<ComboBoxItem>().FirstOrDefault(x => x.Id == productCategory.ProductId);
                if (productItem != null)
                {
                    cbProducts.SelectedItem = productItem;
                }
            }
        }


        private async Task LoadData()
        {
            cbCategories.Items.Clear();
            cbProducts.Items.Clear();

            var categories = await _categoryRepository.GetAllCategoriesAsync();
            foreach (var category in categories)
            {
                cbCategories.Items.Add(new ComboBoxItem { Id = category.CategoryId, Name = category.CategoryName });
            }

            var products = await _productRepository.GetAllProductsAsync();
            foreach (var product in products)
            {
                cbProducts.Items.Add(new ComboBoxItem { Id = product.ProductId, Name = product.ProductName });
            }
        }


        public class ComboBoxItem
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return Name; // Ovo će biti prikazano u ComboBox-u
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (cbCategories.SelectedItem is ComboBoxItem selectedCategory && cbProducts.SelectedItem is ComboBoxItem selectedProduct)
            {
                var productId = selectedProduct.Id;
                var categoryId = selectedCategory.Id;

                var existingProductCategory = await _productCategoryRepository.GetProductCategoryAsync(productId, categoryId);

                if (existingProductCategory != null)
                {
                    // Postoji veza, pa je treba ažurirati, a ne kreirati novu
                    existingProductCategory.ProductId = productId;
                    existingProductCategory.CategoryId = categoryId;

                    await _productCategoryRepository.UpdateProductCategoryAsync(existingProductCategory); // Metoda za ažuriranje

                    MessageBox.Show("Veza između proizvoda i kategorije je uspešno ažurirana.");
                }
                else
                {
                    var productCategory = new ProductCategory
                    {
                        ProductId = productId,
                        CategoryId = categoryId
                    };

                    await _productCategoryRepository.AddProductCategoryAsync(productCategory); // Metoda za dodavanje

                    MessageBox.Show("Nova veza između proizvoda i kategorije je uspešno kreirana.");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Molimo izaberite proizvod i kategoriju!");
            }
        }



    }
}
