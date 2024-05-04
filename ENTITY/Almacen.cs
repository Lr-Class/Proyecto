using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Almacen
    {
        private long _stock;
        private string nombreProducto;
        private string tipoProducto;
        private string presentacionProducto;

        public long Stock { get => _stock; set => _stock = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public string TipoProducto { get => tipoProducto; set => tipoProducto = value; }
        public string PresentacionProducto { get => presentacionProducto; set => presentacionProducto = value; }
        public Almacen(long stock, string nombreProducto, string tipoProducto, string presentacionProducto)
        {
            Stock = stock;
            NombreProducto = nombreProducto;
            TipoProducto = tipoProducto;
            PresentacionProducto = presentacionProducto;
        }
    }
}
