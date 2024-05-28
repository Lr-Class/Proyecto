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
    public partial class FrmTocinetaPedidos : Form
    {
        double[] preciosTocinetaAhumada = { 3500, 5000 };
        public FrmTocinetaPedidos()
        {
            InitializeComponent();
        }

        private void rbPresentacionTocinetaAhumada_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPresentacionTocinetaAhumada1.Checked)
                lblPrecioTocinetaAhumada.Text = preciosTocinetaAhumada[0].ToString("C");
            else if (rbPresentacionTocinetaAhumada2.Checked)
                lblPrecioTocinetaAhumada.Text = preciosTocinetaAhumada[1].ToString("C");
        }
    }
}
