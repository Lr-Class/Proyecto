using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Usuario
    {
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }

        public Usuario(string tipoDocumento, string numeroDocumento, string nombre, string apellido, string nombreUsuario, string contraseña)
        {
            TipoDocumento = tipoDocumento;
            NumeroDocumento = numeroDocumento;
            Nombre = nombre;
            Apellido = apellido;
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
        }
    }
}
