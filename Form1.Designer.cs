namespace FlyCargo.GUI
{
    partial class Form1
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
            btnCategories = new Button();
            btnProductCategories = new Button();
            btnProducts = new Button();
            SuspendLayout();
            // 
            // btnCategories
            // 
            btnCategories.Location = new Point(255, 136);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(205, 38);
            btnCategories.TabIndex = 0;
            btnCategories.Text = "Categories";
            btnCategories.UseVisualStyleBackColor = true;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnProductCategories
            // 
            btnProductCategories.Location = new Point(255, 212);
            btnProductCategories.Name = "btnProductCategories";
            btnProductCategories.Size = new Size(205, 38);
            btnProductCategories.TabIndex = 1;
            btnProductCategories.Text = "Product Categories";
            btnProductCategories.UseVisualStyleBackColor = true;
            btnProductCategories.Click += btnProductCategories_Click;
            // 
            // btnProducts
            // 
            btnProducts.Location = new Point(255, 66);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(205, 38);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProducts);
            Controls.Add(btnProductCategories);
            Controls.Add(btnCategories);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCategories;
        private Button btnProductCategories;
        private Button btnProducts;
    }
}