namespace FlyCargo.GUI
{
    partial class AddProductCategories
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
            cbProducts = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cbCategories = new ComboBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // cbProducts
            // 
            cbProducts.FormattingEnabled = true;
            cbProducts.Location = new Point(101, 60);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new Size(265, 23);
            cbProducts.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Products";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 119);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Categories";
            // 
            // cbCategories
            // 
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(101, 116);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(265, 23);
            cbCategories.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(101, 185);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(167, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // AddProductCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 274);
            Controls.Add(btnSave);
            Controls.Add(cbCategories);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbProducts);
            Name = "AddProductCategories";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddProductCategories";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbProducts;
        private Label label1;
        private Label label2;
        private ComboBox cbCategories;
        private Button btnSave;
    }
}