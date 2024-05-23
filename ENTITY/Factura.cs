using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Factura
    {
        public DateTime FechaFactura { get; set; }
        public string CodigoFactura { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string NombreNegocio { get; set; }
        public string Telefono { get; set; }
        public string DireccionNegocio { get; set; }
        public double TotalFactura { get; set; }
        public double SubTotalFactura { get; set; }
        public double TotalIvaFactura { get; set; }
    }
}
