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
    public partial class GenerateRouteFrom : Form
    {
        DistributionClass distro = new DistributionClass();
        StoreClass[] storesInfo;

        public GenerateRouteFrom()
        {
            InitializeComponent();
            numericUpDown1.Value = 1;
        }

        private void GenerateRouteFrom_Load(object sender, EventArgs e)
        {
            lbError.Hide();
            panelError.Hide();
            lbOk.Hide();
            panelOk.Hide();
            btnCalculate.Enabled = false;

            storesInfo = distro.GetStoresInfoFromQrCodes();
        }

        private void lbError_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            TrucksAndLeftovers ans = distro.CalculateTrucks(storesInfo);
            if (numericUpDown1.Value >= ans.trucks)
            {
                lbError.Hide();
                panelError.Hide();
                panelOk.Show();
                lbOk.Show();
            } else
            {
                lbOk.Hide();
                panelOk.Hide();
                panelError.Show();
                lbError.Show();
            }
        }
    }
}
