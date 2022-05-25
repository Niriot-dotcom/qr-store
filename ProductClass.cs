using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3P_PatyLopez
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public float unitPrice { get; set; }
        public int quantity { get; set; }

        public Product[] GetDefaultProducts()
        {
            Product[] list = new Product[]
            {
                new Product
                {
                    id = 0,
                    name = "soda 600 mL",
                    unitPrice = 3.2f,
                    quantity = 0
                },
                new Product
                {
                    id = 1,
                    name = "'concha' bread",
                    unitPrice = 1.8f,
                    quantity = 0
                },
                new Product
                {
                    id = 2,
                    name = "vegetables 1 kg",
                    unitPrice = 7.4f,
                    quantity = 0
                },
            };

            return list;
        }
    }
}
