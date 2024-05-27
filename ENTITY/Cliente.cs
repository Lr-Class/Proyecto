using System;
using System.Collections.Generic;
using System.Linq;
<<<<<<< HEAD
using System.Net.Mail;
=======
>>>>>>> cb387a640572a7c39f00a0674fa286879e238c7d
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
<<<<<<< HEAD
    public class Cliente : ClsUsuario
    {
        private string _direccion;
        private string _telefono;
        private DateTime Fecha { get; set; }
        private MailAddress Email { get; set; }
        private string NombreNegocio { get; set; }
=======
    public class Cliente : Usuario
    {
        private string _direccion;
        private string _telefono;
        public string Mensaje { get; set; } 

>>>>>>> cb387a640572a7c39f00a0674fa286879e238c7d
        public Cliente()
        {
        }

<<<<<<< HEAD
        public Cliente(string tipoDocumento, string numeroDocumento, string nombre, string apellido,string nombreUsuario, string clave, string direccion, string telefono, DateTime fecha, MailAddress email, string nombreNegocio) : base(tipoDocumento, numeroDocumento, nombre, apellido, nombreUsuario, clave, fecha, email, nombreNegocio)
        {
            Direccion = direccion;
            Telefono = telefono;
            Fecha = fecha;
            Email = email;
        NombreNegocio = nombreNegocio;
=======
        public Cliente(Cliente cliente)
        {
            cliente = new Cliente();
        }
        public Cliente(string mensaje)
        {
            Mensaje = mensaje;
        }

        public Cliente(string tipoDocumento, string numeroDocumento, string nombre, string apellido,string nombreUsuario, string contraseña, string direccion, string telefono) : base(tipoDocumento, numeroDocumento, nombre, apellido, nombreUsuario, contraseña)
        {
            Direccion = direccion;
            Telefono = telefono;
            
>>>>>>> cb387a640572a7c39f00a0674fa286879e238c7d
        }

        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }

        


    }
}
