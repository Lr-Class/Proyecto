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
    public partial class RegistroCliente : Form
    {
        public RegistroCliente()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegistroCliente_Load(object sender, EventArgs e)
        {

        }

        private void rbSiNegocio_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSiNegocio.Checked)
            {
                Color miColor = Color.FromArgb(15, 15, 15);

                txtDireccionNegocio.Enabled = true;
                txtNombreNegocio.Enabled = true;

                txtDireccionNegocio.BackColor = miColor;
                txtNombreNegocio.BackColor = miColor;
            }
        }

        private void rbNoNegocio_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNoNegocio.Checked)
            {
                txtDireccionNegocio.Enabled = false;
                txtNombreNegocio.Enabled = false;

                txtDireccionNegocio.BackColor = Color.DarkRed;
                txtNombreNegocio.BackColor = Color.DarkRed;
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Ya se ha registrado como cliente.\n¿Deseas entrar al prgrama ahora?", "Confirmación", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                FrmInicioCliente inicioCliente = new FrmInicioCliente();
                this.Close();
                inicioCliente.Show();
            }
            else
            {
                this.Close();
            }
        }
    }
}
