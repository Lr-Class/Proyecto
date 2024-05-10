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
    public partial class FrmInicioCliente : Form
    {
        public FrmInicioCliente()
        {
            InitializeComponent();
        }

        public FrmInicioCliente(string usuario)
        {
            InitializeComponent();
            lblNombreUsuario.Text = usuario;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            FrmProductos productos = new FrmProductos();
            this.Close();
            productos.Show();
            
        }

        private void pnlBarraMovimiento_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnHacerPedidos_Click(object sender, EventArgs e)
        {
            FrmPedidos pedidos = new FrmPedidos();
            this.Close();
            pedidos.Show();
        }
    }
}
