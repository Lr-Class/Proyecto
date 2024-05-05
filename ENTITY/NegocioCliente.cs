using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class NegocioCliente
    {
        private string _nombre;
        private string _direccion;
        public NegocioCliente(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
    }
}
