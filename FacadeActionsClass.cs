using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.Json;
using ZXing;

namespace _3P_PatyLopez
{
    class FacadeActionsClass
    {
        private static FacadeActionsClass _instance;
        private FacadeSubsytem1TakeOrder _takeOrderProvider;
        private FacadeSubsystem2GenerateRoute _generateRouteProvider;

        private static readonly object _lock = new object();

        public static FacadeActionsClass GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new FacadeActionsClass();
                        //_instance.Value = value;
                        //_takeOrderProvider = new FacadeSubsytem1TakeOrder();
                        //_generateRouteProvider = new FacadeSubsystem2GenerateRoute();
                    }
                }
            }
            return _instance;
        }

        public FacadeActionsClass()
        {
            _takeOrderProvider = new FacadeSubsytem1TakeOrder();
            _generateRouteProvider = new FacadeSubsystem2GenerateRoute();
        }

        // take order subsystem functions
        public void ShowTakeOrderDialog()
        {
            _takeOrderProvider.ShowForm();
        }

        public AddProductForm ShowAddProductDialog()
        {
            return _takeOrderProvider.ShowAddProductForm();
        }

        // generate route subsystem functions
        public void ShowGenerateRouteDialog()
        {
            _generateRouteProvider.ShowForm();
        }

        public int[] CalculateTrucks(StoreClass[] stores)
        {
            return _generateRouteProvider.CalculateTrucks(stores);
        }

        // general functions
        public string GenerateQrUrlFromStoreInfo(StoreClass storeInfo)
        {
            string storeJson = JsonSerializer.Serialize(storeInfo);
            return "https://api.qrserver.com/v1/create-qr-code/?size=800x800&data=" + storeJson;
        }

        public void SaveQrCodeAsImage(string url, string filepath)
        {
            if (File.Exists(filepath))
            {
                //File.Create(filepath).Close();
                File.Delete(filepath);
            }
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(new Uri(url), filepath);
                //client.DownloadFileAsync(new Uri(url), filepath);
            }
        }

        public StoreClass[] GetStoresInfoFromQrCodes()
        {
            string[] qrFiles = Directory.GetFiles("~/images", String.Format("qrStore*.jpeg"), SearchOption.AllDirectories);
            StoreClass[] storesInfo = new StoreClass[qrFiles.Length];

            for (int i = 0; i < qrFiles.Length; i++)
            {
                Console.WriteLine("file: " + qrFiles[i]);
                storesInfo[i] = GetStoreInfoFromQrCode(Image.FromFile(qrFiles[i]));
            }

            return storesInfo;
        }

        public StoreClass GetStoreInfoFromQrCode(Image qrImg)
        {
            var bitMap = (Bitmap)qrImg;
            var reader = new BarcodeReader();
            var result = reader.Decode(bitMap);

            if (result != null)
            {
                return JsonSerializer.Deserialize<StoreClass>(result.ToString());
            }
            return new StoreClass();
        }
    }
}
