using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Repartidor
    {
        private string _numPedidos;
        private string _Nombre;
        private string _Apellido;
        private string _tipoDocumeto;
        private string _numDocumento;

        public string NumPedidos { get => _numPedidos; set => _numPedidos = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string TipoDocumeto { get => _tipoDocumeto; set => _tipoDocumeto = value; }
        public string NumDocumento { get => _numDocumento; set => _numDocumento = value; }
        public Repartidor(string nombre, string tipoDocumento, string numeroDocumento, string apellido, string numeroPedidos )
        {
            NumDocumento = numeroDocumento;
            TipoDocumeto = tipoDocumento;
            Apellido = apellido;
            Nombre = nombre;
            NumPedidos = numeroPedidos;
        }
        
    }
}
