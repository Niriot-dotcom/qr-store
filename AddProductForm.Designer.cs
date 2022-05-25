namespace _3P_PatyLopez
{
    partial class AddProductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.cbQuantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.cbQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "quantity";
            // 
            // cbProduct
            // 
            this.cbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(83, 124);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(402, 40);
            this.cbProduct.TabIndex = 2;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(335, 430);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(150, 46);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // cbQuantity
            // 
            this.cbQuantity.Location = new System.Drawing.Point(83, 310);
            this.cbQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cbQuantity.Name = "cbQuantity";
            this.cbQuantity.Size = new System.Drawing.Size(402, 39);
            this.cbQuantity.TabIndex = 5;
            this.cbQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 506);
            this.Controls.Add(this.cbQuantity);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.cbProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AddProductForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddProductForm_FormClosing);
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbProduct;
        private Button btnAddProduct;
        private NumericUpDown cbQuantity;
    }
}