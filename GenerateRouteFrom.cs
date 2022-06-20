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
        public GenerateRouteFrom()
        {
            InitializeComponent();
        }

        private void GenerateRouteFrom_Load(object sender, EventArgs e)
        {
            lbError.Hide();
            panelError.Hide();
            lbOk.Hide();
            panelOk.Hide();
            btnCalculate.Enabled = false;
        }

        private void lbError_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
