namespace _3P_PatyLopez
{
    partial class TakeOrderForm
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
            this.components = new System.ComponentModel.Container();
            this.takeOrderBtn = new System.Windows.Forms.Button();
            this.cameraImgBox = new System.Windows.Forms.PictureBox();
            this.camLabel = new System.Windows.Forms.Label();
            this.cameraSelect = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.storePanel = new System.Windows.Forms.Panel();
            this.labelQrGenerated = new System.Windows.Forms.Label();
            this.imgQr = new System.Windows.Forms.PictureBox();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.productsGrid = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeIdLabel = new System.Windows.Forms.Label();
            this.storeNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cameraImgBox)).BeginInit();
            this.storePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgQr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // takeOrderBtn
            // 
            this.takeOrderBtn.Location = new System.Drawing.Point(337, 12);
            this.takeOrderBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.takeOrderBtn.Name = "takeOrderBtn";
            this.takeOrderBtn.Size = new System.Drawing.Size(129, 38);
            this.takeOrderBtn.TabIndex = 0;
            this.takeOrderBtn.Text = "read QR code";
            this.takeOrderBtn.UseVisualStyleBackColor = true;
            this.takeOrderBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // cameraImgBox
            // 
            this.cameraImgBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cameraImgBox.Location = new System.Drawing.Point(31, 64);
            this.cameraImgBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cameraImgBox.Name = "cameraImgBox";
            this.cameraImgBox.Size = new System.Drawing.Size(437, 299);
            this.cameraImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cameraImgBox.TabIndex = 1;
            this.cameraImgBox.TabStop = false;
            this.cameraImgBox.Click += new System.EventHandler(this.qrImg_Click);
            // 
            // camLabel
            // 
            this.camLabel.AutoSize = true;
            this.camLabel.Location = new System.Drawing.Point(31, 24);
            this.camLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.camLabel.Name = "camLabel";
            this.camLabel.Size = new System.Drawing.Size(83, 15);
            this.camLabel.TabIndex = 2;
            this.camLabel.Text = "Select camera:";
            // 
            // cameraSelect
            // 
            this.cameraSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cameraSelect.FormattingEnabled = true;
            this.cameraSelect.Location = new System.Drawing.Point(124, 22);
            this.cameraSelect.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cameraSelect.Name = "cameraSelect";
            this.cameraSelect.Size = new System.Drawing.Size(212, 23);
            this.cameraSelect.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // storePanel
            // 
            this.storePanel.Controls.Add(this.labelQrGenerated);
            this.storePanel.Controls.Add(this.imgQr);
            this.storePanel.Controls.Add(this.btnCreateOrder);
            this.storePanel.Controls.Add(this.productsGrid);
            this.storePanel.Controls.Add(this.storeIdLabel);
            this.storePanel.Controls.Add(this.storeNameLabel);
            this.storePanel.Location = new System.Drawing.Point(31, 64);
            this.storePanel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.storePanel.Name = "storePanel";
            this.storePanel.Size = new System.Drawing.Size(664, 297);
            this.storePanel.TabIndex = 4;
            this.storePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.storePanel_Paint);
            // 
            // labelQrGenerated
            // 
            this.labelQrGenerated.AutoSize = true;
            this.labelQrGenerated.Location = new System.Drawing.Point(486, 47);
            this.labelQrGenerated.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQrGenerated.Name = "labelQrGenerated";
            this.labelQrGenerated.Size = new System.Drawing.Size(113, 30);
            this.labelQrGenerated.TabIndex = 7;
            this.labelQrGenerated.Text = "the new qr code has\r\nbeen generated!";
            this.labelQrGenerated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgQr
            // 
            this.imgQr.Location = new System.Drawing.Point(454, 83);
            this.imgQr.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.imgQr.Name = "imgQr";
            this.imgQr.Size = new System.Drawing.Size(188, 164);
            this.imgQr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgQr.TabIndex = 6;
            this.imgQr.TabStop = false;
            this.imgQr.Click += new System.EventHandler(this.imgQr_Click);
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(288, 264);
            this.btnCreateOrder.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(148, 33);
            this.btnCreateOrder.TabIndex = 5;
            this.btnCreateOrder.Text = "create new order";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // productsGrid
            // 
            this.productsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.nameCol,
            this.unitPriceCol,
            this.quantityCol});
            this.productsGrid.Location = new System.Drawing.Point(0, 83);
            this.productsGrid.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.productsGrid.Name = "productsGrid";
            this.productsGrid.RowHeadersWidth = 82;
            this.productsGrid.RowTemplate.Height = 41;
            this.productsGrid.Size = new System.Drawing.Size(436, 164);
            this.productsGrid.TabIndex = 2;
            this.productsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idCol
            // 
            this.idCol.HeaderText = "id";
            this.idCol.MinimumWidth = 10;
            this.idCol.Name = "idCol";
            // 
            // nameCol
            // 
            this.nameCol.HeaderText = "name";
            this.nameCol.MinimumWidth = 10;
            this.nameCol.Name = "nameCol";
            // 
            // unitPriceCol
            // 
            this.unitPriceCol.HeaderText = "unit price";
            this.unitPriceCol.MinimumWidth = 10;
            this.unitPriceCol.Name = "unitPriceCol";
            // 
            // quantityCol
            // 
            this.quantityCol.HeaderText = "quantity";
            this.quantityCol.MinimumWidth = 10;
            this.quantityCol.Name = "quantityCol";
            // 
            // storeIdLabel
            // 
            this.storeIdLabel.AutoSize = true;
            this.storeIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.storeIdLabel.Location = new System.Drawing.Point(4, 56);
            this.storeIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.storeIdLabel.Name = "storeIdLabel";
            this.storeIdLabel.Size = new System.Drawing.Size(0, 18);
            this.storeIdLabel.TabIndex = 1;
            this.storeIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // storeNameLabel
            // 
            this.storeNameLabel.AutoSize = true;
            this.storeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.storeNameLabel.Location = new System.Drawing.Point(0, 19);
            this.storeNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.storeNameLabel.Name = "storeNameLabel";
            this.storeNameLabel.Size = new System.Drawing.Size(0, 31);
            this.storeNameLabel.TabIndex = 0;
            this.storeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TakeOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 388);
            this.Controls.Add(this.storePanel);
            this.Controls.Add(this.cameraSelect);
            this.Controls.Add(this.camLabel);
            this.Controls.Add(this.cameraImgBox);
            this.Controls.Add(this.takeOrderBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "TakeOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TakeOrderForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TakeOrderForm_FormClosing);
            this.Load += new System.EventHandler(this.TakeOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cameraImgBox)).EndInit();
            this.storePanel.ResumeLayout(false);
            this.storePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgQr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button takeOrderBtn;
        private PictureBox cameraImgBox;
        private Label camLabel;
        private ComboBox cameraSelect;
        private System.Windows.Forms.Timer timer1;
        private Panel storePanel;
        private DataGridView productsGrid;
        private DataGridViewTextBoxColumn idCol;
        private DataGridViewTextBoxColumn nameCol;
        private DataGridViewTextBoxColumn unitPriceCol;
        private DataGridViewTextBoxColumn quantityCol;
        private Label storeIdLabel;
        private Label storeNameLabel;
        private Button btnCreateOrder;
        private PictureBox imgQr;
        private Label label1;
        private Label labelQrGenerated;
    }
}