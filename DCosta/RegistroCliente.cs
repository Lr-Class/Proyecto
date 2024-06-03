using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            label10.Hide();
            txtNombreNegocio.Hide();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

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
                txtNombreNegocio.Show();
                label10.Show();
                txtNombreNegocio.Enabled = true;

                //txtDireccionNegocio.BackColor = miColor;
                txtNombreNegocio.BackColor = miColor;
            }
        }

        private void rbNoNegocio_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNoNegocio.Checked)
            {
                txtNombreNegocio.Hide();
                label10.Hide();
                txtNombreNegocio.Enabled = false;

                //txtDireccionNegocio.BackColor = Color.DarkRed;
                txtNombreNegocio.BackColor = Color.DarkRed;
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Ya se ha registrado como cliente.\n¿Deseas entrar al prgrama ahora?", "Confirmación", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                InicioCliente inicioCliente = new InicioCliente();
                this.Close();
                inicioCliente.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void pnlBarraMovimiento_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
