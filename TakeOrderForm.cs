using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using MessagingToolkit.QRCode.ExceptionHandler;

namespace _3P_PatyLopez
{
    public partial class TakeOrderForm : Form
    {
        FacadeActionsClass facade = FacadeActionsClass.GetInstance();
        public TakeOrderForm()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        StoreClass storeInfo;

        private void button1_Click(object sender, EventArgs e)
        {
            // without live camera
            Image img;
            using (var bmpTemp = new Bitmap("~/images/qrStore2.jpeg"))
            {
                img = new Bitmap(bmpTemp);
            }
            storeInfo = facade.GetStoreInfoFromQrCode(img);
            showStoreInfo(storeInfo);

            // reading QR from camera
            //storePanel.Hide();
            //cameraImgBox.Show();

            //videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cameraSelect.SelectedIndex].MonikerString);
            //videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            //videoCaptureDevice.Start();
            //while (cameraImgBox.Image == null) { }
            //timer1.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            cameraImgBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void qrImg_Click(object sender, EventArgs e)
        {

        }

        private void TakeOrderForm_Load(object sender, EventArgs e)
        {
            storePanel.Hide();
            labelQrGenerated.Hide();

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filterInfoCollection)
                cameraSelect.Items.Add(Device.Name);
            cameraSelect.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
        }

        private void TakeOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
            {
                videoCaptureDevice.SignalToStop();
                videoCaptureDevice.WaitForStop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Image img;
            //using (var bmpTemp = new Bitmap("~/images/qrStore2.jpeg"))
            //{
            //    img = new Bitmap(bmpTemp);
            //}
            //storeInfo = facade.GetStoreInfoFromQrCode(img);
            //showStoreInfo(storeInfo);
            storeInfo = facade.GetStoreInfoFromQrCode(cameraImgBox.Image);
            timer1.Stop();
            if (videoCaptureDevice.IsRunning == true)
            {
                videoCaptureDevice.SignalToStop();
                videoCaptureDevice.WaitForStop();
                cameraImgBox.Image = null;
                cameraImgBox.Hide();
                if (storeInfo != null)
                {
                    showStoreInfo(storeInfo);
                }
            }
        }

        private void showStoreInfo(StoreClass storeInfo)
        {
            productsGrid.Rows.Clear();
            productsGrid.Refresh();

            storeIdLabel.Text = "ID: " + storeInfo.storeId;
            storeNameLabel.Text = storeInfo.storeName;

            foreach (Product p in storeInfo.products)
            {
                productsGrid.Rows.Add(p.id, p.name, p.unitPrice, p.quantity);
            }

            storePanel.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            productsGrid.Rows.Clear();
            productsGrid.Refresh();
            AddProductForm apf = facade.ShowAddProductDialog();
            storeInfo.products = apf.list.ToArray();

            foreach (Product p in apf.list)
            {
                productsGrid.Rows.Add(p.id, p.name, p.unitPrice, p.quantity);
            }

            //labelQrGenerated.Show();
            //sleep(3);
            //labelQrGenerated.Hide();

            var t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += (s, e) =>
            {
                labelQrGenerated.Show();
                t.Stop();
            };
            labelQrGenerated.Hide();
            t.Start();

            // generating new QR code
            string urlImg = facade.GenerateQrUrlFromStoreInfo(storeInfo);
            imgQr.Load(urlImg);
            facade.SaveQrCodeAsImage(urlImg, "~/images/qrStore" + storeInfo.storeId + ".jpeg");
            // TODO add event
        }

        private async void sleep(double secs)
        {
            var timer = new PeriodicTimer(TimeSpan.FromSeconds(secs));

            while (await timer.WaitForNextTickAsync())
            {
                //Business logic
            }
        }

        private void storePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imgQr_Click(object sender, EventArgs e)
        {

        }
    }
}
