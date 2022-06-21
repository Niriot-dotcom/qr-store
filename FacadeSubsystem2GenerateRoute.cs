using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3P_PatyLopez
{
    public class FacadeSubsystem2GenerateRoute
    {
        public void ShowForm()
        {
            GenerateRouteForm generateRouteFrom = new GenerateRouteForm();
            generateRouteFrom.ShowDialog();
        }

        private int GetTotalTrucks(int sodas, int breads, int veggies)
        {
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
                z++;

            return x + y + z;
        }

        public int[] CalculateTrucks(StoreClass[] stores)
        {
            int[] ans = new int[2] { 0, 0 };
            int sodas = 0;
            int breads = 0;
            int veggies = 0;

            // total products quantity calculation
            foreach (StoreClass s in stores)
            {
                float profit = 0f;
                if (s.products != null && s.products.Length > 0)
                {
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
                } else
                {
                    Console.WriteLine("there are no products in store {0}", s.storeId);
                }
                s.profit = profit;
            }

            ans[0] = GetTotalTrucks(sodas, breads, veggies);
            // TODO
            ans[1] = 0;
            return ans;
        }
    }
}
