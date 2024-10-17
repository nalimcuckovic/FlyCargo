using FlyCargo.Models.Data;
using FlyCargo.Models.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace FlyCargo.GUI
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _httpClient;

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _httpClient = new HttpClient();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=FlyCargo;Trusted_Connection=True;");

            using (var context = new AppDbContext(optionsBuilder.Options))
            {
                IProductRepository productRepository = new ProductRepository(context);

                ProductForm productForm = new ProductForm(productRepository);
                productForm.StartPosition = FormStartPosition.CenterScreen;
                productForm.Show();
            }
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=FlyCargo;Trusted_Connection=True;");

            using (var context = new AppDbContext(optionsBuilder.Options))
            {
                ICategoryRepository categoryRepository = new CategoryRepository(context);

                CategoriesForm categoriesForm = new CategoriesForm(categoryRepository);
                categoriesForm.StartPosition = FormStartPosition.CenterScreen;
                categoriesForm.Show();
            }
        }

        private void btnProductCategories_Click(object sender, EventArgs e)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=FlyCargo;Trusted_Connection=True;");

            // Kreiraj instancu IProductCategoryRepository
            IProductCategoryRepository productCategoryRepository = new ProductCategoryRepository(new AppDbContext(optionsBuilder.Options));
            IProductRepository productRepository = new ProductRepository(new AppDbContext(optionsBuilder.Options));
            ICategoryRepository categoryRepository = new CategoryRepository(new AppDbContext(optionsBuilder.Options));

            // Kreiraj formu i prosledi repo
            ProductCategoryForm productCategoryForm = new ProductCategoryForm(productCategoryRepository, productRepository, categoryRepository);
            productCategoryForm.StartPosition = FormStartPosition.CenterScreen;
            productCategoryForm.Show();
        }

       
    }
}
