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
            // ProductCategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvProductCategories);
            Name = "ProductCategoryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ProductCategoryForm";
            ((System.ComponentModel.ISupportInitialize)dgvProductCategories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProductCategories;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}