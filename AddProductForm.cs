using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3P_PatyLopez
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        public List<Product> list;
        private Product[] defaultList;

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string name = cbProduct.Text;
                if (name == "" || name == null)
                {
                    return;
                }
                int quantity = (int)cbQuantity.Value;

                Product p = Array.Find(defaultList, p => p.name == name);
                Console.WriteLine("name: " + p.name);
                p.quantity = quantity;
                list.Add(p);
            } catch { }
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            list = new List<Product>();
            defaultList = new Product().GetDefaultProducts();
            foreach (Product p in defaultList)
                cbProduct.Items.Add(p.name);
        }

        private void AddProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("product list:" + list.Count + "\n");
            //foreach (Product p in list)
            //{
            //    Console.WriteLine("p: " + p);
            //    Console.WriteLine("name: " + p.name);
            //    Console.WriteLine("quantity: " + p.quantity);
            //}
        }
    }
}
