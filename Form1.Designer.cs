namespace _3P_PatyLopez
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbLogs = new System.Windows.Forms.TextBox();
            this.checkBoxGrid = new System.Windows.Forms.CheckBox();
            this.checkBoxTextbox = new System.Windows.Forms.CheckBox();
            this.checkBoxTxt = new System.Windows.Forms.CheckBox();
            this.gridLogs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.colDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEventDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbLogs);
            this.panel1.Controls.Add(this.checkBoxGrid);
            this.panel1.Controls.Add(this.checkBoxTextbox);
            this.panel1.Controls.Add(this.checkBoxTxt);
            this.panel1.Controls.Add(this.gridLogs);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1243, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 1134);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tbLogs
            // 
            this.tbLogs.Location = new System.Drawing.Point(0, 276);
            this.tbLogs.Multiline = true;
            this.tbLogs.Name = "tbLogs";
            this.tbLogs.Size = new System.Drawing.Size(753, 486);
            this.tbLogs.TabIndex = 5;
            // 
            // checkBoxGrid
            // 
            this.checkBoxGrid.AutoSize = true;
            this.checkBoxGrid.Font = new System.Drawing.Font("Ebrima", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxGrid.Location = new System.Drawing.Point(572, 144);
            this.checkBoxGrid.Name = "checkBoxGrid";
            this.checkBoxGrid.Size = new System.Drawing.Size(103, 44);
            this.checkBoxGrid.TabIndex = 4;
            this.checkBoxGrid.Text = "Grid";
            this.checkBoxGrid.UseVisualStyleBackColor = true;
            this.checkBoxGrid.CheckedChanged += new System.EventHandler(this.checkBoxGrid_CheckedChanged);
            // 
            // checkBoxTextbox
            // 
            this.checkBoxTextbox.AutoSize = true;
            this.checkBoxTextbox.Font = new System.Drawing.Font("Ebrima", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxTextbox.Location = new System.Drawing.Point(312, 144);
            this.checkBoxTextbox.Name = "checkBoxTextbox";
            this.checkBoxTextbox.Size = new System.Drawing.Size(157, 44);
            this.checkBoxTextbox.TabIndex = 3;
            this.checkBoxTextbox.Text = "Text box";
            this.checkBoxTextbox.UseVisualStyleBackColor = true;
            this.checkBoxTextbox.CheckedChanged += new System.EventHandler(this.checkBoxTextbox_CheckedChanged);
            // 
            // checkBoxTxt
            // 
            this.checkBoxTxt.AutoSize = true;
            this.checkBoxTxt.Font = new System.Drawing.Font("Ebrima", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxTxt.Location = new System.Drawing.Point(40, 144);
            this.checkBoxTxt.Name = "checkBoxTxt";
            this.checkBoxTxt.Size = new System.Drawing.Size(142, 44);
            this.checkBoxTxt.TabIndex = 2;
            this.checkBoxTxt.Text = "TXT file";
            this.checkBoxTxt.UseVisualStyleBackColor = true;
            this.checkBoxTxt.CheckedChanged += new System.EventHandler(this.checkBoxTxt_CheckedChanged);
            // 
            // gridLogs
            // 
            this.gridLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDateTime,
            this.colEventDescription});
            this.gridLogs.Location = new System.Drawing.Point(0, 806);
            this.gridLogs.Name = "gridLogs";
            this.gridLogs.RowHeadersWidth = 82;
            this.gridLogs.RowTemplate.Height = 41;
            this.gridLogs.Size = new System.Drawing.Size(753, 328);
            this.gridLogs.TabIndex = 1;
            this.gridLogs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLogs_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DejaVu Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(312, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("DejaVu Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(325, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(482, 260);
            this.button1.TabIndex = 1;
            this.button1.Text = "✍️ take order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("DejaVu Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(325, 536);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(482, 260);
            this.button2.TabIndex = 2;
            this.button2.Text = "🚚 generate delivery route";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // colDateTime
            // 
            this.colDateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDateTime.FillWeight = 187.1795F;
            this.colDateTime.HeaderText = "Date time";
            this.colDateTime.MinimumWidth = 180;
            this.colDateTime.Name = "colDateTime";
            this.colDateTime.Width = 180;
            // 
            // colEventDescription
            // 
            this.colEventDescription.FillWeight = 12.82051F;
            this.colEventDescription.HeaderText = "Event description";
            this.colEventDescription.MinimumWidth = 200;
            this.colEventDescription.Name = "colEventDescription";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2008, 1158);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView gridLogs;
        private TextBox tbLogs;
        private CheckBox checkBoxGrid;
        private CheckBox checkBoxTextbox;
        private CheckBox checkBoxTxt;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn colDateTime;
        private DataGridViewTextBoxColumn colEventDescription;
    }
}