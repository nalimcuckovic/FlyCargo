namespace FlyCargo.GUI
{
    partial class CategoriesForm
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
            dgvCategories = new DataGridView();
            btnDelete = new Button();
            tbCategoryName = new TextBox();
            dtpCreatedAt = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            btnSave = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // dgvCategories
            // 
            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(183, 57);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.RowTemplate.Height = 25;
            dgvCategories.Size = new Size(607, 282);
            dgvCategories.TabIndex = 0;
            dgvCategories.DoubleClick += dgvCategories_DoubleClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(21, 309);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(134, 30);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // tbCategoryName
            // 
            tbCategoryName.Location = new Point(21, 75);
            tbCategoryName.Name = "tbCategoryName";
            tbCategoryName.Size = new Size(134, 23);
            tbCategoryName.TabIndex = 4;
            // 
            // dtpCreatedAt
            // 
            dtpCreatedAt.Location = new Point(21, 139);
            dtpCreatedAt.Name = "dtpCreatedAt";
            dtpCreatedAt.Size = new Size(134, 23);
            dtpCreatedAt.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 57);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 6;
            label1.Text = "Category name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 121);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 7;
            label2.Text = "Created at";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(21, 201);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(134, 30);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 39);
            label3.Name = "label3";
            label3.Size = new Size(230, 15);
            label3.TabIndex = 9;
            label3.Text = "For edit you must double click in data grid";
            // 
            // CategoriesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 363);
            Controls.Add(label3);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpCreatedAt);
            Controls.Add(tbCategoryName);
            Controls.Add(btnDelete);
            Controls.Add(dgvCategories);
            Name = "CategoriesForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CategoriesForm";
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCategories;
        private Button btnDelete;
        private TextBox tbCategoryName;
        private DateTimePicker dtpCreatedAt;
        private Label label1;
        private Label label2;
        private Button btnSave;
        private Label label3;
    }
}