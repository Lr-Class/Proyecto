using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DLL
{
public class ClienteRepository
    {
        SqlConnection connection;
        List<ClsCliente> clientes;
        public ClienteRepository(ConnectionManager Connection)
        {
            connection = Connection.connection;
            clientes = new List<ClsCliente>();
        }
        public void GuardarCliente(ClsCliente cliente)
        {
            using(var comando = connection.CreateCommand() )

            {
               
            }
        }
    }
}
