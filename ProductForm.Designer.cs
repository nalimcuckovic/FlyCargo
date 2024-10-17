namespace FlyCargo.GUI
{
    partial class ProductForm
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
            dgvProducts = new DataGridView();
            btnSave = new Button();
            btnDelete = new Button();
            tbProductName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbProductPrice = new TextBox();
            label3 = new Label();
            dtpProductCreated = new DateTimePicker();
            label4 = new Label();
            tbProductDescription = new TextBox();
            label5 = new Label();
            nudProductStockQuantity = new NumericUpDown();
            label6 = new Label();
            btnSearch = new Button();
            tbSearchByName = new TextBox();
            cbClearSearch = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudProductStockQuantity).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(274, 67);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowTemplate.Height = 25;
            dgvProducts.Size = new Size(657, 385);
            dgvProducts.TabIndex = 0;
            dgvProducts.DoubleClick += dgvProducts_DoubleClick;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(32, 344);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(210, 30);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(31, 422);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(211, 30);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // tbProductName
            // 
            tbProductName.Location = new Point(31, 37);
            tbProductName.MaxLength = 50;
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new Size(211, 23);
            tbProductName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 19);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(274, 45);
            label2.Name = "label2";
            label2.Size = new Size(230, 15);
            label2.TabIndex = 5;
            label2.Text = "For edit you must double click in data grid";
            // 
            // tbProductPrice
            // 
            tbProductPrice.Location = new Point(31, 85);
            tbProductPrice.MaxLength = 9;
            tbProductPrice.Name = "tbProductPrice";
            tbProductPrice.Size = new Size(211, 23);
            tbProductPrice.TabIndex = 6;
            tbProductPrice.KeyPress += tbProductPrice_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 67);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 7;
            label3.Text = "Price";
            // 
            // dtpProductCreated
            // 
            dtpProductCreated.Location = new Point(31, 135);
            dtpProductCreated.Name = "dtpProductCreated";
            dtpProductCreated.Size = new Size(211, 23);
            dtpProductCreated.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 117);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 9;
            label4.Text = "Created";
            // 
            // tbProductDescription
            // 
            tbProductDescription.Location = new Point(31, 245);
            tbProductDescription.MaxLength = 150;
            tbProductDescription.Multiline = true;
            tbProductDescription.Name = "tbProductDescription";
            tbProductDescription.Size = new Size(210, 61);
            tbProductDescription.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 227);
            label5.Name = "label5";
            label5.Size = new Size(156, 15);
            label5.TabIndex = 11;
            label5.Text = "Description (max. 150 chars)";
            // 
            // nudProductStockQuantity
            // 
            nudProductStockQuantity.Location = new Point(31, 188);
            nudProductStockQuantity.Name = "nudProductStockQuantity";
            nudProductStockQuantity.Size = new Size(210, 23);
            nudProductStockQuantity.TabIndex = 12;
            nudProductStockQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 170);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 13;
            label6.Text = "Stock quantity";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(526, 35);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(111, 25);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbSearchByName
            // 
            tbSearchByName.Location = new Point(643, 35);
            tbSearchByName.Name = "tbSearchByName";
            tbSearchByName.Size = new Size(192, 23);
            tbSearchByName.TabIndex = 15;
            // 
            // cbClearSearch
            // 
            cbClearSearch.AutoSize = true;
            cbClearSearch.Location = new Point(841, 41);
            cbClearSearch.Name = "cbClearSearch";
            cbClearSearch.Size = new Size(90, 19);
            cbClearSearch.TabIndex = 16;
            cbClearSearch.Text = "Clear search";
            cbClearSearch.UseVisualStyleBackColor = true;
            cbClearSearch.CheckedChanged += cbClearSearch_CheckedChanged;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 498);
            Controls.Add(cbClearSearch);
            Controls.Add(tbSearchByName);
            Controls.Add(btnSearch);
            Controls.Add(label6);
            Controls.Add(nudProductStockQuantity);
            Controls.Add(label5);
            Controls.Add(tbProductDescription);
            Controls.Add(label4);
            Controls.Add(dtpProductCreated);
            Controls.Add(label3);
            Controls.Add(tbProductPrice);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbProductName);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(dgvProducts);
            Name = "ProductForm";
            Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudProductStockQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducts;
        private Button btnSave;
        private Button btnDelete;
        private TextBox tbProductName;
        private Label label1;
        private Label label2;
        private TextBox tbProductPrice;
        private Label label3;
        private DateTimePicker dtpProductCreated;
        private Label label4;
        private TextBox tbProductDescription;
        private Label label5;
        private NumericUpDown nudProductStockQuantity;
        private Label label6;
        private Button btnSearch;
        private TextBox tbSearchByName;
        private CheckBox cbClearSearch;
    }
}