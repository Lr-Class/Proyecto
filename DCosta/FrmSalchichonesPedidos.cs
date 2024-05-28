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
    public partial class FrmSalchichonesPedidos : Form
    {
        double[] preciosSalchichondeRes = { 3000, 5000};
        double[] preciosSalchichondePollo = { 2500, 4000, 6000, 8000};
        double[] preciosSalchichonCervecero = { 4500, 6500 };
        public FrmSalchichonesPedidos()
        {
            InitializeComponent();
        }

        private void rbPresentacionSalchichondePollo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPresentacionSalchichondePollo1.Checked)
                lblPrecioSalchichondePollo.Text = preciosSalchichondePollo[0].ToString("C");
            else if (rbPresentacionSalchichondePollo2.Checked)
                lblPrecioSalchichondePollo.Text = preciosSalchichondePollo[1].ToString("C");
            else if (rbPresentacionSalchichondePollo3.Checked)
                lblPrecioSalchichondePollo.Text = preciosSalchichondePollo[2].ToString("C");
            else if (rbPresentacionSalchichondePollo4.Checked)
                lblPrecioSalchichondePollo.Text = preciosSalchichondePollo[3].ToString("C");
        }

        private void rbPresentacionSalchichonCervecero_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPresentacionSalchichonCervecero1.Checked)
                lblPrecioSalchichonCervecero.Text = preciosSalchichonCervecero[0].ToString("C");
            else if (rbPresentacionSalchichonCervecero2.Checked)
                lblPrecioSalchichonCervecero.Text = preciosSalchichonCervecero[1].ToString("C");
        }

        private void rbPresentacionSalchichondeRes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPresentacionSalchichondeRes1.Checked)
                lblPrecioSalchichondeRes.Text = preciosSalchichondeRes[0].ToString("C");
            else if (rbPresentacionSalchichondeRes2.Checked)
                lblPrecioSalchichondeRes.Text = preciosSalchichondeRes[1].ToString("C");
        }
    }
}
