using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Pedidos
    {
        private string _codigo;
        private string _estadoPedido; // Verifica que el pedido se haya entregado
        private readonly TimeSpan _horaInicio;
        private readonly TimeSpan _horaFinalizacion;
        private DateTime _fechaPedido;

        public string Codigo { get => _codigo; set => _codigo = value; }
        public string EstadoPedido { get => _estadoPedido; set => _estadoPedido = value; }
        public DateTime FechaPedido { get => _fechaPedido; set => _fechaPedido = value; }

        public TimeSpan HoraInicio => _horaInicio;

        public TimeSpan HoraFinalizacion => _horaFinalizacion;
        public Pedidos()
        {
            
        }
        public Pedidos(string codigo, string estadoPedido, TimeSpan horaInicio, TimeSpan horaFinalizacion, DateTime fechaPedido)
        {
            Codigo = codigo;
            EstadoPedido = estadoPedido;
            FechaPedido = fechaPedido;
        }
    }
}
