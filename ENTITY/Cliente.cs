using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Cliente : Usuario
    {
        private string _direccion;
        private string _telefono;

        public Cliente()
        {
        }

        public Cliente(string tipoDocumento, string numeroDocumento, string nombre, string apellido,string nombreUsuario, string contraseña, string direccion, string telefono) : base(tipoDocumento, numeroDocumento, nombre, apellido, nombreUsuario, contraseña)
        {
            Direccion = direccion;
            Telefono = telefono;
            
        }

        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }

        


    }
}
