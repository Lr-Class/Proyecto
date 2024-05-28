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
    public partial class FrmMortadelaPedidos : Form
    {
        double[] preciosMortadeladeRes = { 3500, 5000, 7000, 9000 };
        public FrmMortadelaPedidos()
        {
            InitializeComponent();
        }

        private void rbPresentacionMortadeladeRes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPresentacionMortadeladeRes1.Checked)
                lblPrecioMortadeladeRes.Text = preciosMortadeladeRes[0].ToString("C");
            else if (rbPresentacionMortadeladeRes2.Checked)
                lblPrecioMortadeladeRes.Text = preciosMortadeladeRes[1].ToString("C");
            else if (rbPresentacionMortadeladeRes3.Checked)
                lblPrecioMortadeladeRes.Text = preciosMortadeladeRes[2].ToString("C");
            else if (rbPresentacionMortadeladeRes4.Checked)
                lblPrecioMortadeladeRes.Text = preciosMortadeladeRes[3].ToString("C");
        }
    }
}
