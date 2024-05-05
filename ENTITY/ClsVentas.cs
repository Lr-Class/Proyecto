using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class ClsVentas
    {
        private string _codigoVenta;
        private double _ventaRepartidor;
        private double _ventaTotal;
        private DateTime _fechaVentaTotal;
        private DateTime _fechaVentaRepartidor;

        public string CodigoVenta { get => _codigoVenta; set => _codigoVenta = value; }
        public double VentaRepartidor { get => _ventaRepartidor; set => _ventaRepartidor = value; }
        public double VentaTotal { get => _ventaTotal; set => _ventaTotal = value; }
        public DateTime FechaVentaTotal { get => _fechaVentaTotal; set => _fechaVentaTotal = value; }
        public DateTime FechaVentaRepartidor { get => _fechaVentaRepartidor; set => _fechaVentaRepartidor = value; }
        public ClsVentas(string codigoVenta, double ventaRepartidor, double ventaTotal, DateTime fechaVentaTotal, DateTime fechaVentaRepartidor)
        {
            CodigoVenta = codigoVenta;
            VentaRepartidor = ventaRepartidor;
            VentaTotal = ventaTotal;
            FechaVentaTotal = fechaVentaTotal;
            FechaVentaRepartidor = fechaVentaRepartidor;
        }
    }
}
