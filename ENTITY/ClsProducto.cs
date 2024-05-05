using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Producto
    {
        private string _nombre;
        private string _presentacion;
        private string _tipoProducto;
        private double _precio;
        private string _codigoProducto;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Presentacion { get => _presentacion; set => _presentacion = value; }
        public string TipoProducto { get => _tipoProducto; set => _tipoProducto = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public string CodigoProducto { get => _codigoProducto; set => _codigoProducto = value; }
        public Producto(string nombre, string codigo, string presentacion, string tipo, double precioProducto)
        {
            Nombre = nombre;
            CodigoProducto = codigo;
            Presentacion = presentacion;
            TipoProducto = tipo;
            Precio = precioProducto;
        }
    }
}
