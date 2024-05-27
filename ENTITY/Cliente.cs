using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Cliente : ClsUsuario
    {
        private string _direccion;
        private string _telefono;
        private DateTime Fecha { get; set; }
        private MailAddress Email { get; set; }
        private string NombreNegocio { get; set; }
        public Cliente()
        {
        }

        public Cliente(string tipoDocumento, string numeroDocumento, string nombre, string apellido,string nombreUsuario, string clave, string direccion, string telefono, DateTime fecha, MailAddress email, string nombreNegocio) : base(tipoDocumento, numeroDocumento, nombre, apellido, nombreUsuario, clave, fecha, email, nombreNegocio)
        {
            Direccion = direccion;
            Telefono = telefono;
            Fecha = fecha;
            Email = email;
        NombreNegocio = nombreNegocio;
        }

        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }

        


    }
}
