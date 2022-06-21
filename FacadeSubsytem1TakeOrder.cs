using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.Json;
using ZXing;

namespace _3P_PatyLopez
{
    public class FacadeSubsytem1TakeOrder
    {
        public void ShowForm()
        {
            TakeOrderForm takeOrderForm = new TakeOrderForm();
            takeOrderForm.ShowDialog();
        }

        public AddProductForm ShowAddProductForm()
        {
            AddProductForm productForm = new AddProductForm();
            productForm.ShowDialog();
            return productForm;
        }
    }
}
