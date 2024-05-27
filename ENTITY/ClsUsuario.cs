using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class ClsUsuario
    {
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public DateTime Fecha { get; set; }
        public MailAddress Email { get; set; }
        public string NombreNegocio { get; set; }
        public ClsUsuario(string tipoDocumento, string numeroDocumento, string nombre, string apellido, string nombreUsuario, string clave, DateTime fecha,MailAddress email, string nombreNegocio)
        {
            TipoDocumento = tipoDocumento;
            NumeroDocumento = numeroDocumento;
            Nombre = nombre;
            Apellido = apellido;
            NombreUsuario = nombreUsuario;
            Clave = clave;
            Fecha = fecha;
            Email = email;
            NombreNegocio = nombreNegocio;
        }

        public ClsUsuario() { 
        
        }
    }
}
