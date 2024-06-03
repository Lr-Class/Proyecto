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
    public partial class Jamon : Form
    {
        public Jamon()
        {
            InitializeComponent();
        }

        public void Agregar_Producto(object sender, EventArgs e, string nombreProducto, string presentacion)
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
            //pbImagenProducto.Image = Properties.Resources.SalchichaSuprema; 
            //Aqui deberia mencionarse el nombre de la imagen o traerla directa desde la otra ventana
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

            Label lblpresentacionLabel = new Label();
            lblpresentacionLabel.Text = presentacion;
            lblpresentacionLabel.Font = new Font("Century Gothic", 12);
            lblpresentacionLabel.Location = new Point(56, 100);
            pnlTitulosMuestra.Controls.Add(lblpresentacionLabel);

            flowLayoutPanel2.Controls.Add(productoPanel);
        }
    }
}
