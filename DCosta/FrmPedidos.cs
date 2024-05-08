using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace DCosta
{
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmInicioCliente frmInicioCliente = new FrmInicioCliente();
            frmInicioCliente.ShowDialog();
        }

        private void AbrirVentanaEnPanel(object formHijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);

            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (cbTipoCarnico.SelectedItem.ToString() == "Salchichas")
            {
                AbrirVentanaEnPanel(new FrmSalchichasPedidos());
            }
            if (cbTipoCarnico.SelectedItem.ToString() == "Butifarras")
            {
                AbrirVentanaEnPanel(new FrmButifarrasPedidos());
            }
            if (cbTipoCarnico.SelectedItem.ToString() == "Chorizos")
            {
                AbrirVentanaEnPanel(new FrmChorizosPedidos());
            }
            if (cbTipoCarnico.SelectedItem.ToString() == "Jamon")
            {
                AbrirVentanaEnPanel(new FrmJamonPedidos());
            }
            if (cbTipoCarnico.SelectedItem.ToString() == "Mortadela")
            {
                AbrirVentanaEnPanel(new FrmMortadelaPedidos());
            }
            if (cbTipoCarnico.SelectedItem.ToString() == "Salchichones")
            {
                AbrirVentanaEnPanel(new FrmSalchichonesPedidos());
            }
            if (cbTipoCarnico.SelectedItem.ToString() == "Hamburguesa")
            {
                AbrirVentanaEnPanel(new FrmHamburguesaPedidos());
            }
            if (cbTipoCarnico.SelectedItem.ToString() == "Tocineta")
            {
                AbrirVentanaEnPanel(new FrmTocinetaPedidos());
            }
        }

        private void btnPedidoCarnicos_Click(object sender, EventArgs e)
        {
            btnPedidoCarnicos.ImageIndex = 1;
            btnPedidoComplementarios.ImageIndex = btnPedidosGuardar.ImageIndex = 0;
            pnlComplementarios.Width = pnlGuardarPedido.Width = 0;
            lblLine1.BackColor = lblLine2.BackColor = Color.FromArgb(228,228,228);
        }

        private void btnPedidoComplementarios_Click(object sender, EventArgs e)
        {
            if (btnPedidoCarnicos.ImageIndex == 0 || btnPedidoCarnicos.ImageIndex == 1)
            {
                btnPedidoCarnicos.ImageIndex = 2;
                btnPedidoComplementarios.ImageIndex = 1;
                btnPedidosGuardar.ImageIndex = 0;
                pnlComplementarios.Width = pnlPrincipal.Width;
                //pnlComplementarios.Location = new System.Drawing.Point(10,9);
                pnlCarnicos.Width = pnlGuardarPedido.Width = 0;
                lblLine1.BackColor = Color.FromArgb(72, 226, 40);
                lblLine2.BackColor = Color.FromArgb(228, 228, 228);
            }
        }

        private void btnPedidosGuardar_Click(object sender, EventArgs e)
        {
            if (btnPedidoCarnicos.ImageIndex == 2 && btnPedidoComplementarios.ImageIndex == 1 || btnPedidoComplementarios.ImageIndex == 2)
            {
                btnPedidoComplementarios.ImageIndex = 2;
                btnPedidosGuardar.ImageIndex = 1;
                pnlGuardarPedido.Width = pnlPrincipal.Width;
                lblLine2.BackColor = Color.FromArgb(72, 226, 40);
            }
        }
    }
}
