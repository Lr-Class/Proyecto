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
    public partial class FrmHamburguesaPedidos : Form
    {
        double[] precioHamburguesadeRes = { 7500 };
        public FrmHamburguesaPedidos()
        {
            InitializeComponent();
        }

        private void rbPresentacionHamburguesadeRes_CheckedChanged(object sender, EventArgs e)
        {
            lblPrecioHamburguesa.Text = precioHamburguesadeRes[0].ToString("C");
        }
    }
}
