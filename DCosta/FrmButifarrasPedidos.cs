using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCosta
{
    public partial class FrmButifarrasPedidos : Form
    {
        double[] preciosButifarra = { 2800, 3500, 4500, 6000 };
        public FrmButifarrasPedidos()
        {
            InitializeComponent();
        }

        private void rbPresentacionButifarra_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPresentacionButifarra1.Checked)
                lblPrecioButifarra.Text = preciosButifarra[0].ToString("C");
            else if (rbPresentacionButifarra2.Checked)
                lblPrecioButifarra.Text = preciosButifarra[1].ToString("C");
            else if (rbPresentacionButifarra3.Checked)
                lblPrecioButifarra.Text = preciosButifarra[2].ToString("C");
            else if (rbPresentacionButifarra4.Checked)
                lblPrecioButifarra.Text = preciosButifarra[3].ToString("C");
        }
    }
}
