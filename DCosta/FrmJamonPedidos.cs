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
    public partial class FrmJamonPedidos : Form
    {
        double[] preciosJamonEspecial = { 5000, 6000, 7000, 15000, 18000, 20000 };
        public FrmJamonPedidos()
        {
            InitializeComponent();
        }
        private void rbPresentacionJamonEspecial_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPresentacionJamonEspecial1.Checked)
                lblPrecioJamonEspecial.Text = preciosJamonEspecial[0].ToString("C");
            else if (rbPresentacionJamonEspecial2.Checked)
                lblPrecioJamonEspecial.Text = preciosJamonEspecial[1].ToString("C");
            else if (rbPresentacionJamonEspecial3.Checked)
                lblPrecioJamonEspecial.Text = preciosJamonEspecial[2].ToString("C");
            else if (rbInstitucionalJamonEspecial1.Checked)
                lblPrecioJamonEspecial.Text = preciosJamonEspecial[3].ToString("C");
            else if (rbInstitucionalJamonEspecial2.Checked)
                lblPrecioJamonEspecial.Text = preciosJamonEspecial[4].ToString("C");
            else if (rbInstitucionalJamonEspecial3.Checked)
                lblPrecioJamonEspecial.Text = preciosJamonEspecial[5].ToString("C");
        }
    }
}
