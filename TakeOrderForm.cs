using System;
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
        public TakeOrderForm()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        private void button1_Click(object sender, EventArgs e)
        {
            // reading QR from camera
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cameraSelect.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
            while (cameraImgBox.Image == null) { }
            timer1.Start();

            // read custom qr for each store
            var store1 = new StoreClass
            {
                storeId = 1,
                storeName = "tienda 1",
                products = new Product[]
                {
                    new Product
                    {
                        id = 1,
                        name = "gansito",
                        unitPrice = 12.5f,
                        quantity = 50
                    },
                }
            };

            string store1json = JsonSerializer.Serialize(store1);

            //GetStoreInfo(store1json);
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            cameraImgBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private async void GetStoreInfo(string jsonInfo)
        {
            if (jsonInfo == "")
            {
                //
            }
            string urlImage = "https://api.qrserver.com/v1/create-qr-code/?size=150x150&data=" + jsonInfo;
            cameraImgBox.Load(urlImage);
        }

        private void qrImg_Click(object sender, EventArgs e)
        {

        }

        private void TakeOrderForm_Load(object sender, EventArgs e)
        {
            // hide store info
            storePanel.Hide();

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
            var bitMap = (Bitmap)cameraImgBox.Image;
            var reader = new BarcodeReader();
            var result = reader.Decode(bitMap);

            if (result != null)
            {
                StoreClass? info = JsonSerializer.Deserialize<StoreClass>(result.ToString());
                timer1.Stop();
                if (videoCaptureDevice.IsRunning == true)
                {
                    videoCaptureDevice.SignalToStop();
                    videoCaptureDevice.WaitForStop();
                    cameraImgBox.Image = null;
                    cameraImgBox.Hide();
                    if (info != null)
                    {
                        showStoreInfo(info);
                    }
                }
            }
        }

        private void showStoreInfo(StoreClass info)
        {
            storeIdLabel.Text += info.storeId;
            storeNameLabel.Text += info.storeName;
            //productsGrid;

            storePanel.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
