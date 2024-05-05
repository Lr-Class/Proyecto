using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Administrador : Usuario
    {
        public Administrador(string nombreUsuario, string contraseña,string tipoDocumento = "", string numeroDocumento = "", string nombre = "", string apellido = ""  ) : base(tipoDocumento, numeroDocumento, nombre, apellido, nombreUsuario, contraseña)
        {
            this.NombreUsuario = nombreUsuario;
            this.Contraseña = contraseña;
        }
    }
}
