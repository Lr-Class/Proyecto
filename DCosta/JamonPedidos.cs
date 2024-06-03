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
    public partial class JamonPedidos : Form
    {
        double[] preciosJamonEspecial = { 5000, 6000, 7000, 15000, 18000, 20000 };
        public JamonPedidos()
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

            flowLayoutPanel2.Controls.Add(productoPanel);
        }
    }
}
