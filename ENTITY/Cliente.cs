using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Cliente : Usuario
    {
        public Cliente(string tipoDocumento, string numeroDocumento, string nombre, string apellido, string nombreUsuario, string contraseña) : base(tipoDocumento, numeroDocumento, nombre, apellido, nombreUsuario, contraseña)
        {
        }
    }
}
