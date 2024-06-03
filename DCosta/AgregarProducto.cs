using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace DCosta
{
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {

            //Aqui pones lo de agregar para la logica y esas cosas
            //Yo abajo hago lo de la muestra

            string nombreProducto = txtNombreProducto.Text;
            string presentacion = txtPresentacion1.Text;
            decimal precio = decimal.Parse(txtPrecio1.Text);

            if (cbEnQueProductoSeAgrega.SelectedItem.ToString() == "Salchichas")
            {
                Salchichas salchichas = new Salchichas();
                salchichas.Agregar_Producto(this, EventArgs.Empty, nombreProducto,presentacion);
                SalchichasPedidos salchichasPedidos = new SalchichasPedidos();
                salchichasPedidos.Agregar_Producto(this, EventArgs.Empty, nombreProducto, presentacion,precio);
            
            }
            if (cbEnQueProductoSeAgrega.SelectedItem.ToString() == "Butifarras")
            {
                Butifarras butifarras = new Butifarras();
                butifarras.Agregar_Producto(this, EventArgs.Empty, nombreProducto, presentacion);
                ButifarrasPedidos butifarrasPedidos = new ButifarrasPedidos();
                butifarrasPedidos.Agregar_Producto(this, EventArgs.Empty, nombreProducto, presentacion, precio);

            }
            if (cbEnQueProductoSeAgrega.SelectedItem.ToString() == "Chorizos")
            {
                Chorizos chorizos = new Chorizos();
                chorizos.Agregar_Producto(this, EventArgs.Empty, nombreProducto, presentacion);
                ChorizosPedidos chorizosPedidos = new ChorizosPedidos();
                chorizosPedidos.Agregar_Producto(this, EventArgs.Empty, nombreProducto, presentacion, precio);
            
            }
            if (cbEnQueProductoSeAgrega.SelectedItem.ToString() == "Jamon")
            {
                Jamon jamon = new Jamon();
                jamon.Agregar_Producto(this, EventArgs.Empty, nombreProducto, presentacion);
                JamonPedidos jamonPedidos = new JamonPedidos();
                jamonPedidos.Agregar_Producto(this, EventArgs.Empty, nombreProducto, presentacion, precio);

            }
            if (cbEnQueProductoSeAgrega.SelectedItem.ToString() == "Mortadela")
            {
                Mortadela mortadela = new Mortadela();
                mortadela.Agregar_Producto(this, EventArgs.Empty, nombreProducto, presentacion);
                MortadelaPedidos mortadelaPedidos = new MortadelaPedidos();
                mortadelaPedidos.Agregar_Producto(this, EventArgs.Empty, nombreProducto, presentacion,precio);

            }
            if (cbEnQueProductoSeAgrega.SelectedItem.ToString() == "Salchichones")
            {
                Salchichones salchichones = new Salchichones();
                salchichones.Agregar_Producto(this, EventArgs.Empty, nombreProducto, presentacion);
                SalchichasPedidos salchichasPedidos = new SalchichasPedidos(); ;
                salchichasPedidos.Agregar_Producto(this, EventArgs.Empty, nombreProducto, presentacion,precio);

            }
            if (cbEnQueProductoSeAgrega.SelectedItem.ToString() == "Hamburguesa")
            {
                Hamburguesa hamburguesa = new Hamburguesa();
                hamburguesa.Agregar_Producto(this, EventArgs.Empty, nombreProducto, presentacion);
                HamburguesaPedidos hamburguesaPedidos = new HamburguesaPedidos();
                hamburguesaPedidos.Agregar_Producto(this, EventArgs.Empty, nombreProducto, presentacion, precio);

            }
            if (cbEnQueProductoSeAgrega.SelectedItem.ToString() == "Tocineta")
            {
                Tocineta tocineta = new Tocineta();
                tocineta.Agregar_Producto(this, EventArgs.Empty, nombreProducto, presentacion);
                TocinetaPedidos tocinetaPedidos = new TocinetaPedidos();
                tocinetaPedidos.Agregar_Producto(this, EventArgs.Empty, nombreProducto, presentacion, precio);

            }


        }
    }
}
