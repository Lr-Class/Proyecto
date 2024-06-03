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
    public partial class SalchichasPedidos : Form
    {
        double[] precioSalchichaSuprema = { 8500 };
        double[] preciosSalchichaExtralarga = { 4000, 5500 };
        double[] preciosSalchikids = { 3200, 4200 };
        double[] preciosSalchichaParrillera = { 3800, 4800, 6000, 7500 };
        double[] precioSalchichaMiniperro = { 2500 };
        double[] preciosSalchichaSuper = { 4800, 6000 };
        double[] precioMegaSalchicha = { 7200 };
        double[] preciosSalchichaMaxiperro = { 3200, 4200 };

        public SalchichasPedidos()
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

        public void Agregar_Producto(object sender, EventArgs e, string nombreProducto, string presentacion, decimal precio)
        {
            Panel productoPanel = new Panel();
            productoPanel.BackColor = Color.Transparent;
            productoPanel.BorderStyle = BorderStyle.FixedSingle;
            productoPanel.Size = new Size(755, 205);

            Panel pnlTitulosMuestra = new Panel();
            pnlTitulosMuestra.BackColor = Color.Transparent;
            pnlTitulosMuestra.Size = new Size(439, 149);
            pnlTitulosMuestra.Location = new Point(289, 29);
            productoPanel.Controls.Add(pnlTitulosMuestra);

            PictureBox pbImagenProducto = new PictureBox();
            // pbImagenProducto.Image = Properties.Resources.SalchichaSuprema; 
            // Aquí debería mencionarse el nombre de la imagen o traerla directamente desde la otra ventana
            pbImagenProducto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagenProducto.Size = new Size(250, 180);
            pbImagenProducto.Location = new Point(18, 19);
            productoPanel.Controls.Add(pbImagenProducto);

            Label lblnombreProducto = new Label();
            lblnombreProducto.Text = nombreProducto;
            lblnombreProducto.Font = new Font("Century Gothic", 22, FontStyle.Bold);
            lblnombreProducto.ForeColor = Color.Red;
            lblnombreProducto.Location = new Point(17, 10);
            pnlTitulosMuestra.Controls.Add(lblnombreProducto);

            Label lbltituloPresentacion = new Label();
            lbltituloPresentacion.Text = "Presentacion: ";
            lbltituloPresentacion.Font = new Font("Century Gothic", 16, FontStyle.Bold);
            lbltituloPresentacion.Location = new Point(23, 75);
            pnlTitulosMuestra.Controls.Add(lbltituloPresentacion);

            Label lblTituloPrecio = new Label();
            lblTituloPrecio.Text = "Precio: ";
            lblTituloPrecio.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            lblTituloPrecio.Location = new Point(486, 183);
            productoPanel.Controls.Add(lblTituloPrecio);

            Label lblPrecio = new Label();
            lblPrecio.Font = new Font("Century Gothic", 12);
            lblPrecio.Location = new Point(557, 183);
            productoPanel.Controls.Add(lblPrecio);

            Button btnAgregar = new Button();
            btnAgregar.Font = new Font("Microsoft Sans Serif", 8);
            btnAgregar.Size = new Size(76, 26);
            btnAgregar.Location = new Point(655, 183);
            productoPanel.Controls.Add(btnAgregar);

            RadioButton rbPresentacion = new RadioButton();
            rbPresentacion.Text = presentacion;
            rbPresentacion.Font = new Font("Century Gothic", 12);
            rbPresentacion.Location = new Point(56, 100);
            rbPresentacion.CheckedChanged += (s, ev) =>
            {
                if (rbPresentacion.Checked)
                {
                    lblPrecio.Text = precio.ToString("C");
                }
            };
            pnlTitulosMuestra.Controls.Add(rbPresentacion);

            flowLayoutPanel1.Controls.Add(productoPanel);
        }

    }
}
