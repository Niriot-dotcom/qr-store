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
    public partial class GenerateRouteForm : Form
    {
        FacadeActionsClass facade = FacadeActionsClass.GetInstance();
        StoreClass[] storesInfo;

        Label[] LbStoreNames;
        Label[] LbStoreProfits;
        Label[] LbArrows;
        PictureBox[] PbStoreIcons;

        public GenerateRouteForm()
        {
            InitializeComponent();
        }

        private void HideComponents()
        {
            // error dialog
            lbError.Hide();
            panelError.Hide();

            // ok dialog
            lbOk.Hide();
            panelOk.Hide();

            // route simulation
            lbDistribution.Hide();

                // store name labels
                lbStore1.Hide();
                lbStore2.Hide();
                lbStore3.Hide();
                lbStore4.Hide();
                lbStore5.Hide();

                // store profit labels
                lbProfit1.Hide();
                lbProfit2.Hide();
                lbProfit3.Hide();
                lbProfit4.Hide();
                lbProfit5.Hide();

                // arrows labels
                lbArrow1.Hide();
                lbArrow2.Hide();
                lbArrow3.Hide();
                lbArrow4.Hide();

                // picture box for store icons
                pbStore1.Hide();
                pbStore2.Hide();
                pbStore3.Hide();
                pbStore4.Hide();
                pbStore5.Hide();
        }

        private void GenerateRouteFrom_Load(object sender, EventArgs e)
        {
            HideComponents();
            btnCalculate.Enabled = false;
            storesInfo = facade.GetStoresInfoFromQrCodes();
            foreach (var s in storesInfo)
            {
                Console.WriteLine("s.id: " + s.storeId);
                Console.WriteLine("s.name: " + s.storeName);
                Console.WriteLine("s.prods.count: " + s.products.Length);
                //foreach (var p in s.products)
                //{
                //    Console.WriteLine();
                //    Console.WriteLine(s.storeName);
                //}
                Console.WriteLine();
            }

            LbStoreNames = new Label[5] { lbStore1, lbStore2, lbStore3, lbStore4, lbStore5 };
            LbStoreProfits = new Label[5] { lbProfit1, lbProfit2, lbProfit3, lbProfit4, lbProfit5 };
            LbArrows = new Label[4] { lbArrow1, lbArrow2, lbArrow3, lbArrow4 };
            PbStoreIcons = new PictureBox[5] { pbStore1, pbStore2, pbStore3, pbStore4, pbStore5 };
        }

        private void lbError_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int[] ans = facade.CalculateTrucks(storesInfo);
            if (numericUpDown1.Value >= ans[0])
            {
                lbError.Hide();
                panelError.Hide();
                panelOk.Show();
                lbOk.Show();

                btnCalculate.Enabled = true;
            } else
            {
                lbOk.Hide();
                panelOk.Hide();
                panelError.Show();
                lbError.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // hiding error dialog
            lbError.Hide();
            panelError.Hide();

            // hiding ok dialog
            lbOk.Hide();
            panelOk.Hide();

            // showing route
            int i = 0;
            foreach (var s in storesInfo.OrderByDescending(s => s.profit))
            {
                if (i < storesInfo.Length - 1)
                {
                    LbArrows[i].Show();
                }
                LbStoreNames[i].Text = s.storeName;
                LbStoreNames[i].Show();

                LbStoreProfits[i].Text = "profit: $" + s.profit.ToString();
                LbStoreProfits[i].Show();

                PbStoreIcons[i].Show();
                i++;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
