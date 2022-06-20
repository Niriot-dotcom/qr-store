namespace _3P_PatyLopez
{
    partial class GenerateRouteFrom
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbTrucks = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            this.panelError = new System.Windows.Forms.Panel();
            this.panelOk = new System.Windows.Forms.Panel();
            this.lbOk = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panelError.SuspendLayout();
            this.panelOk.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "how many trucks do you want to use?";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown1.Location = new System.Drawing.Point(20, 64);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 35);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lbTrucks
            // 
            this.lbTrucks.AutoSize = true;
            this.lbTrucks.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTrucks.Location = new System.Drawing.Point(146, 66);
            this.lbTrucks.Name = "lbTrucks";
            this.lbTrucks.Size = new System.Drawing.Size(76, 29);
            this.lbTrucks.TabIndex = 2;
            this.lbTrucks.Text = "trucks";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCalculate.Location = new System.Drawing.Point(542, 24);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(230, 57);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "calculate route";
            this.btnCalculate.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(654, 500);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 48);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbError.Location = new System.Drawing.Point(5, 28);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(538, 58);
            this.lbError.TabIndex = 6;
            this.lbError.Text = "❌ the demand for the products is not met, please\r\nincrease the number of trucks.";
            this.lbError.Click += new System.EventHandler(this.lbError_Click);
            // 
            // panelError
            // 
            this.panelError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelError.Controls.Add(this.lbError);
            this.panelError.Location = new System.Drawing.Point(99, 146);
            this.panelError.Name = "panelError";
            this.panelError.Size = new System.Drawing.Size(607, 118);
            this.panelError.TabIndex = 7;
            // 
            // panelOk
            // 
            this.panelOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelOk.Controls.Add(this.lbOk);
            this.panelOk.Location = new System.Drawing.Point(99, 146);
            this.panelOk.Name = "panelOk";
            this.panelOk.Size = new System.Drawing.Size(607, 65);
            this.panelOk.TabIndex = 8;
            // 
            // lbOk
            // 
            this.lbOk.AutoSize = true;
            this.lbOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbOk.Location = new System.Drawing.Point(5, 7);
            this.lbOk.Name = "lbOk";
            this.lbOk.Size = new System.Drawing.Size(549, 58);
            this.lbOk.TabIndex = 8;
            this.lbOk.Text = "✔️ the demand is met and {} products are left over.\r\n\r\n";
            // 
            // GenerateRouteFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.panelOk);
            this.Controls.Add(this.panelError);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lbTrucks);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Name = "GenerateRouteFrom";
            this.Text = "GenerateRouteFrom";
            this.Load += new System.EventHandler(this.GenerateRouteFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panelError.ResumeLayout(false);
            this.panelError.PerformLayout();
            this.panelOk.ResumeLayout(false);
            this.panelOk.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label lbTrucks;
        private Button btnCalculate;
        private Button btnOk;
        private Button btnCancel;
        private Label lbError;
        private Panel panelError;
        private Panel panelOk;
        private Label lbOk;
        private Button btnClose;
    }
}