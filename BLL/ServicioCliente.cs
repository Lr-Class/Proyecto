using ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioCliente
    {
        public ServicioCliente() 
        { 

        }
        public static string RegistroCliente (string tipoDocumento, string numeroDocumento, string nombre, string apellido, string nombreUsuario, string contraseña,string direccion,string telefono)
        {
            Cliente cliente = new Cliente (tipoDocumento,numeroDocumento,nombre,apellido,nombreUsuario,contraseña,direccion,telefono);
            
        }
        public static DataTable RegistroCliente ( Cliente cliente)
        {
            DataTable datosClientes = new DataTable();
            
        }

    }
}
