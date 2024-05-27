using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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
<<<<<<< HEAD:ENTITY/ClsUsuario.cs
        public string Clave { get; set; }
        public DateTime Fecha { get; set; }
        public MailAddress Email { get; set; }
        public string NombreNegocio { get; set; }
        public ClsUsuario(string tipoDocumento, string numeroDocumento, string nombre, string apellido, string nombreUsuario, string clave, DateTime fecha,MailAddress email, string nombreNegocio)
=======
        public string Contraseña { get; set; }

        public Usuario(string tipoDocumento, string numeroDocumento, string nombre, string apellido, string nombreUsuario, string contraseña)
>>>>>>> cb387a640572a7c39f00a0674fa286879e238c7d:ENTITY/Usuario.cs
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

        public Usuario() { 
        
        }
    }
}
