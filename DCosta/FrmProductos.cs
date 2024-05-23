﻿using System;
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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenuVertical.Width == 270)
            {
                pbDcostaLogo.Visible = false;
                pbDcostaLogoAbajo.Visible = true;
                pnlMenuVertical.Width = 60;
            }
            else
            {
                pbDcostaLogo.Visible = true;
                pbDcostaLogoAbajo.Visible = false;
                pnlMenuVertical.Width = 270;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmInicioCliente frmInicioCliente = new FrmInicioCliente();
            frmInicioCliente.ShowDialog();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void pnlBarraMovimiento_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void btnProductoSalchichas_Click(object sender, EventArgs e)
        {
            AbrirVentanaEnPanel(new FrmSalchichas());
        }

        private void btnProductoButifarra_Click(object sender, EventArgs e)
        {
            AbrirVentanaEnPanel(new FrmButifarras());
        }

        private void btnProductoJamon_Click(object sender, EventArgs e)
        {
            AbrirVentanaEnPanel(new FrmJamon());
        }

        private void btnProductoMortadela_Click(object sender, EventArgs e)
        {
            AbrirVentanaEnPanel(new FrmMortadela());
        }

        private void btnProductoTocineta_Click(object sender, EventArgs e)
        {
            AbrirVentanaEnPanel(new FrmTocineta());
        }

        private void btnProductoHamburguesa_Click(object sender, EventArgs e)
        {
            AbrirVentanaEnPanel(new FrmHamburguesa());
        }

        private void btnProductoChorizo_Click(object sender, EventArgs e)
        {
            AbrirVentanaEnPanel(new FrmChorizos());
        }

        private void btnProductoSalchichones_Click(object sender, EventArgs e)
        {
            AbrirVentanaEnPanel(new FrmSalchichones());
        }
    }
}
