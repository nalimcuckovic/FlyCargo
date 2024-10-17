namespace FlyCargo.GUI
{
    partial class ProductCategoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProductCategories = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            tbSearchByName = new TextBox();
            cbSearch = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductCategories).BeginInit();
            SuspendLayout();
            // 
            // dgvProductCategories
            // 
            dgvProductCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductCategories.Location = new Point(21, 99);
            dgvProductCategories.Name = "dgvProductCategories";
            dgvProductCategories.RowTemplate.Height = 25;
            dgvProductCategories.Size = new Size(753, 223);
            dgvProductCategories.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(52, 43);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 35);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(273, 43);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 35);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(501, 43);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 35);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(52, 341);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 27);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbSearchByName
            // 
            tbSearchByName.Location = new Point(208, 341);
            tbSearchByName.Name = "tbSearchByName";
            tbSearchByName.Size = new Size(200, 23);
            tbSearchByName.TabIndex = 5;
            // 
            // cbSearch
            // 
            cbSearch.AutoSize = true;
            cbSearch.Location = new Point(414, 346);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(90, 19);
            cbSearch.TabIndex = 6;
            cbSearch.Text = "Clear search";
            cbSearch.UseVisualStyleBackColor = true;
            cbSearch.CheckedChanged += cbSearch_CheckedChanged;
            // 
            // ProductCategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbSearch);
            Controls.Add(tbSearchByName);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvProductCategories);
            Name = "ProductCategoryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ProductCategoryForm";
            ((System.ComponentModel.ISupportInitialize)dgvProductCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductCategories;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSearch;
        private TextBox tbSearchByName;
        private CheckBox cbSearch;
    }
}