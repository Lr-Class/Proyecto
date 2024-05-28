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
    public partial class FrmSalchichasPedidos : Form
    {
        double[] precioSalchichaSuprema = { 8500 };
        double[] preciosSalchichaExtralarga = { 4000, 5500 };
        double[] preciosSalchikids = { 3200, 4200 };
        double[] preciosSalchichaParrillera = { 3800, 4800, 6000, 7500 };
        double[] precioSalchichaMiniperro = { 2500 };
        double[] preciosSalchichaSuper = { 4800, 6000 };
        double[] precioMegaSalchicha = { 7200 };
        double[] preciosSalchichaMaxiperro = { 3200, 4200 };

        public FrmSalchichasPedidos()
        {
            InitializeComponent();
        }

        private void rbPresentacionSalchichaSuprema_CheckedChanged(object sender, EventArgs e)
        {
            lblPrecioSalchichaSuprema.Text = precioSalchichaSuprema[0].ToString("C");
        }

        private void rbPresentacionSalchichaExtralarga_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPresentacionSalchichaExtralarga1.Checked)
                lblPrecioSalchichaExtralarga.Text = preciosSalchichaExtralarga[0].ToString("C");
            else if (rbPresentacionSalchichaExtralarga2.Checked)
                lblPrecioSalchichaExtralarga.Text = preciosSalchichaExtralarga[1].ToString("C");
        }

        private void rbPresentacionSalchikids_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPresentacionSalchikids1.Checked)
                lblPrecioSalchickids.Text = preciosSalchikids[0].ToString("C");
            else if (rbPresentacionSalchikids2.Checked)
                lblPrecioSalchickids.Text = preciosSalchikids[1].ToString("C");
        }

        private void rbPresentacionSalchichaParrillera_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPresentacionSalchichaParrillera1.Checked)
                lblPrecioSalchichaParrillera.Text = preciosSalchichaParrillera[0].ToString("C");
            else if (rbPresentacionSalchichaParrillera2.Checked)
                lblPrecioSalchichaParrillera.Text = preciosSalchichaParrillera[1].ToString("C");
            else if (rbPresentacionSalchichaParrillera3.Checked)
                lblPrecioSalchichaParrillera.Text = preciosSalchichaParrillera[2].ToString("C");
            else if (rbPresentacionSalchichaParrillera4.Checked)
                lblPrecioSalchichaParrillera.Text = preciosSalchichaParrillera[3].ToString("C");
        }

        private void rbPresentacionSalchichaMiniperro_CheckedChanged(object sender, EventArgs e)
        {
            lblPrecioSalchichaMiniperro.Text = precioSalchichaMiniperro[0].ToString("C");
        }

        private void rbPresentacionSalchichaSuper_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPresentacionSalchichaSuper1.Checked)
                lblPrecioSalchichaSuper.Text = preciosSalchichaSuper[0].ToString("C");
            else if (rbPresentacionSalchichaSuper2.Checked)
                lblPrecioSalchichaSuper.Text = preciosSalchichaSuper[1].ToString("C");
        }

        private void rbPresentacionMegaSalchicha_CheckedChanged(object sender, EventArgs e)
        {
            lblPrecioMegaSalchicha.Text = precioMegaSalchicha[0].ToString("C");
        }

        private void rbPresentacionSalchichaMaxiperro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPresentacionSalchichaMaxiperro1.Checked)
                lblPrecioSalchichaMaxiperro.Text = preciosSalchichaMaxiperro[0].ToString("C");
            else if (rbPresentacionSalchichaMaxiperro2.Checked)
                lblPrecioSalchichaMaxiperro.Text = preciosSalchichaMaxiperro[1].ToString("C");
        }
    }
}
