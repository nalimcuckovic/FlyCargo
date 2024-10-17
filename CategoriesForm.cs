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
    public partial class CategoriesForm : Form
    {
        private readonly ICategoryRepository _categoryRepository;

        private readonly AppDbContext _context;
        private int? selectedCategoryId = null;

        public CategoriesForm(ICategoryRepository categoryRepository)
        {
            InitializeComponent();
            _categoryRepository = categoryRepository;
            _context = new AppDbContext();


            this.Load += CategoriesForm_Load;
        }

        private async void CategoriesForm_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            await LoadCategoriesAsync(_context);
        }

        private async Task LoadCategoriesAsync(AppDbContext _context, string sSearchByName = null)
        {
            try
            {
                _context = new AppDbContext();
                await _context.Categories.LoadAsync(); // Asinkrono učitavanje podataka

                var categoriesQuery = _context.Categories.AsQueryable();

                // Ako je prosleđen parametar sSearchByName, filtriraj kategorije po nazivu
                if (!string.IsNullOrEmpty(sSearchByName))
                {
                    categoriesQuery = categoriesQuery.Where(c => c.CategoryName.Contains(sSearchByName));
                }

                var categories = await categoriesQuery.ToListAsync();

                // Postavi podatke u DataGridView
                dgvCategories.DataSource = categories.Select(c => new
                {
                    c.CategoryId,
                    c.CategoryName,
                    c.CreatedAt
                }).ToList();

                dgvCategories.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 


        private void SetupDataGridView()
        {
            dgvCategories.Columns.Clear();
        }


        private async void btnSave_Click(object sender, EventArgs e)
        {
            string sCategoryName = tbCategoryName.Text;
            DateTime dtCreatedAt = dtpCreatedAt.Value;

            if (string.IsNullOrWhiteSpace(sCategoryName))
            {
                MessageBox.Show("You did not input a category name!");
                return;
            }

            CategoryRepository categoryRepository = new CategoryRepository(_context);

            if (selectedCategoryId.HasValue)
            {
                Category categoryToUpdate = await categoryRepository.GetCategoryById(selectedCategoryId.Value);

                if (categoryToUpdate != null)
                {
                    categoryToUpdate.CategoryName = sCategoryName;
                    categoryToUpdate.CreatedAt = dtCreatedAt;

                    await categoryRepository.UpdateCategory(categoryToUpdate);
                }
            }
            else
            {
                Category newCategory = new Category
                {
                    CategoryName = sCategoryName,
                    CreatedAt = dtCreatedAt
                };

                await categoryRepository.AddCategory(newCategory);
            }

            CategoriesForm_Load(sender, e);
            tbCategoryName.Text = string.Empty;
            dtpCreatedAt.Value = DateTime.Now;
            selectedCategoryId = null;
        }

        private void dgvCategories_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCategories.CurrentRow != null)
            {
                selectedCategoryId = Convert.ToInt32(dgvCategories.CurrentRow.Cells["CategoryId"].Value);
                string selectedCategoryName = dgvCategories.CurrentRow.Cells["CategoryName"].Value.ToString();
                DateTime selectedCreatedAt = Convert.ToDateTime(dgvCategories.CurrentRow.Cells["CreatedAt"].Value);

                tbCategoryName.Text = selectedCategoryName;
                dtpCreatedAt.Value = selectedCreatedAt;
            }
            else
            {
                MessageBox.Show("You did not double click grid view!");
                return;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCategories.CurrentRow != null)
            {
                int categoryId = Convert.ToInt32(dgvCategories.CurrentRow.Cells["CategoryId"].Value);

                // Proveri da li se kategorija može obrisati
                CategoryRepository categoryRepository = new CategoryRepository(_context);
                bool canDelete = await categoryRepository.CanDeleteCategory(categoryId);

                if (canDelete)
                {
                    MessageBox.Show("This category cannot be deleted because it is linked to existing products.", "Delete Not Allowed", MessageBoxButtons.OK);
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this category?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    await categoryRepository.DeleteCategory(categoryId);
                    CategoriesForm_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Please select a category to delete.");
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string sSearchByName = tbSearchByName.Text;
            if (String.IsNullOrEmpty(sSearchByName) || sSearchByName.Count() < 1)
            {
                MessageBox.Show("For search category, you must input min. 2 chars!");
                return;
            }

            await LoadCategoriesAsync(_context, sSearchByName);
        }

        private async void cbClearSearch_CheckedChanged(object sender, EventArgs e)
        {
            string sSearchByName = tbSearchByName.Text;
            if (!String.IsNullOrEmpty(sSearchByName))
            {
                tbSearchByName.Text = String.Empty;
                await LoadCategoriesAsync(_context);
            }
        }
    }
}
