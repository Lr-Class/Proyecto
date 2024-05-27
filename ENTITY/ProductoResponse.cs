using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class ProductoResponse
    {
        public class ConsultarProductoResponse
        {
            public List<Producto> Productos { get; set; }
            public string Mensaje { get; set; }
            public bool Encontrado { get; set; }
            public ConsultarProductoResponse(List<Producto> productos)
            {
                productos = new List<Producto>();
                Productos = productos;
                Encontrado = true;
            }
            public ConsultarProductoResponse(string mensaje)
            {
                Mensaje = mensaje;
                Encontrado = false;
            }
        }
    }
}
