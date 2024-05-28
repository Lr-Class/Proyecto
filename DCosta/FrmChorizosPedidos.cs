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
    public partial class FrmChorizosPedidos : Form
    {
        double[] precioChorizodeResCosteño = { 6000 };
        double[] preciosChorizoParrilla = { 4500, 6000, 7500 };
        double[] preciosChoripincho = { 2800, 3500, 4500 };

        public FrmChorizosPedidos()
        {
            InitializeComponent();
        }

        private void rbPresentacionChorizodeResCosteño_CheckedChanged(object sender, EventArgs e)
        {
            lblPrecioChorizodeRes.Text = precioChorizodeResCosteño[0].ToString("C");
        }

        private void rbPresentacionChorizoParrilla_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPresentacionChorizoParrilla1.Checked)
                lblPrecioChorizoParrilla.Text = preciosChorizoParrilla[0].ToString("C");
            else if (rbPresentacionChorizoParrilla2.Checked)
                lblPrecioChorizoParrilla.Text = preciosChorizoParrilla[1].ToString("C");
            else if (rbPresentacionChorizoParrilla3.Checked)
                lblPrecioChorizoParrilla.Text = preciosChorizoParrilla[2].ToString("C");
        }

        private void rbPresentacionChoripincho_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPresentacionChoripincho1.Checked)
                lblPrecioChoripincho.Text = preciosChoripincho[0].ToString("C");
            else if (rbPresentacionChoripincho2.Checked)
                lblPrecioChoripincho.Text = preciosChoripincho[1].ToString("C");
            else if (rbPresentacionChoripincho3.Checked)
                lblPrecioChoripincho.Text = preciosChoripincho[2].ToString("C");
        }
    }
}
