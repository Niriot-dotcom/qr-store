using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

using ZXing;

namespace _3P_PatyLopez
{
    public class DistributionClass
    {
        private Image[] QrCodesImg;
        public StoreClass[] GetStoresInfoFromQrCodes()
        {
            string[] qrFiles = Directory.GetFiles("~/images", String.Format("qrStore*.jpeg"), SearchOption.AllDirectories);
            QrCodesImg = new Image[qrFiles.Length];
            StoreClass[] storesInfo = new StoreClass[qrFiles.Length];

            for (int i = 0; i < qrFiles.Length; i++)
            {
                QrCodesImg[i] = Image.FromFile(qrFiles[i]);
                var bitMap = (Bitmap)QrCodesImg[i];
                var reader = new BarcodeReader();
                var result = reader.Decode(bitMap);

                if (result != null)
                {
                    StoreClass storeInfo = JsonSerializer.Deserialize<StoreClass>(result.ToString());
                    Console.WriteLine("storeinfo: " + storeInfo.products[0].name);
                    storesInfo[i] = storeInfo;
                }
            }

            return storesInfo;
        }

        public TrucksAndLeftovers CalculateTrucks(StoreClass[] stores)
        {
            TrucksAndLeftovers ans = new TrucksAndLeftovers();
            int sodas = 0;
            int breads = 0;
            int veggies = 0;

            foreach (StoreClass s in stores)
            {
                float profit = 0f;
                foreach (Product p in s.products)
                {
                    if (p.id == 0)
                    {
                        sodas += p.quantity;
                    }
                    else if (p.id == 1)
                    {
                        breads += p.quantity;
                    }
                    else if (p.id == 2)
                    {
                        veggies += p.quantity;
                    }
                    profit += (p.quantity * p.unitPrice);
                }
                s.profit = profit;
            }

            // 3 de refrescos, 120 cada uno
            int sodasPerTruck = 120;
            int x = sodas / sodasPerTruck;
            if (sodas % sodasPerTruck > 0)
                x++;

            // 3 de pan, 270 cada uno
            int breadsPerTruck = 270;
            int y = breads / breadsPerTruck;
            if (breads % breadsPerTruck > 0)
                y++;

            // 3 de verdura, 95 cada uno
            int veggiesPerTruck = 95;
            int z = veggies / veggiesPerTruck;
            if (veggies % veggiesPerTruck > 0)
            {
                z++;
            }

            ans.trucks = x + y + z;
            // TODO
            ans.leftovers = 0;

            Console.WriteLine("truck needed: " + ans.trucks);
            return ans;
        }
    }

    public class TrucksAndLeftovers
    {
        public int trucks = 0;
        public int leftovers = 0;
    }
}
