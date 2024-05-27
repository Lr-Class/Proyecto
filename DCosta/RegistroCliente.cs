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
<<<<<<< HEAD

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbTipoInicio_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private string RegistrarCliente()
        {
            if (ValidarTextosVacios())
            {
                Cliente cliente = MapearTextoCliente();
                string mensaje = ClsServicioCliente.RegistroCliente(cliente);
                NegocioCliente negocio = MapearTextoNegocio();
                string mensaje2 = ClsServicioNegocioCliente.RegistroNegocio(negocio);
                return mensaje + " - " + mensaje2;  

            }else
            {
                return "Rellene los datos faltantes";
            }
        }
        private Cliente MapearTextoCliente()
        {
            var cliente = new ClsCliente("", "", "", "", "", "", "", "");
            cliente.TipoDocumento = MapearComboTipoDocumento(cbTipoInicio.Text);
            cliente.NumeroDocumento = txtNumDocumento.Text;
            cliente.Nombre = txtNombres.Text;
            cliente.Apellido = txtApellidos.Text;
            cliente.NombreUsuario = txtNombreUsuario.Text;
            cliente.Contraseña = txtPassword.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.Direccion = txtDireccionDomicilio.Text;
            return cliente;
            
        }
        private NegocioCliente MapearTextoNegocio ()
        {
            var negocio = new NegocioCliente();
            if (rbSiNegocio.Checked)
            {
                negocio.Direccion = txtDireccionNegocio.Text;
                negocio.Nombre = txtNombreNegocio.Text; 
            } else
            {
                negocio.Nombre = "";
                negocio.Direccion = "";
            }
            return negocio;
        }
       
        private bool ValidarTextosVacios()
        {
            foreach (Control itemcontrol in this.Controls)
            {
                if (itemcontrol is TextBox textBox && string.IsNullOrEmpty(textBox.Text))
                {
                    return false;
                }

            }
            return true;
        }
        private string MapearComboTipoDocumento(string tipoDocumento)
        {
            if (tipoDocumento.Equals("TI"))
            {
                return "Tarjeta de identidad";

                
            } 
            else if (tipoDocumento.Equals("CC"))
            {
                return "Cedula";
            } 
            else
            {
                return "Cedula de extranjeria";
            }
            
        }

        private void txtNumDocumento_TextChanged(object sender, EventArgs e)
        {

=======
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
>>>>>>> cb387a640572a7c39f00a0674fa286879e238c7d
        }
    }
}
