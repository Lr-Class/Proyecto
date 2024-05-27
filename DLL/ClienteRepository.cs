using ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
   public class ClienteRepository
    {
        SqlConnection connection;
        List<Cliente> clientes;
        public ClienteRepository(ConexionDbDCostaFood Connection)
        {
            connection = Connection.connection;
            clientes = new List<Cliente>();

        }
        public void GuardarCliente(Cliente cliente)
        {
            using (var comando = connection.CreateCommand())
          {
                comando.CommandText = "INSERT INTO Cliente (TipoDocumento,NumeroDocumento,Nombre,Apellido,NombreUsuario,Contraseña,Telefono,Direccion) " +
                     "VALUES(@TipoDocumento,@NumeroDocumento,@Nombre,@Apellido,@NombreUsuario,@Contraseña,@Telefono,@Direccion)";

                comando.Parameters.AddWithValue("@TipoDocumento", cliente.TipoDocumento);
                comando.Parameters.AddWithValue("@NumeroDocumento", cliente.NumeroDocumento);
                comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                comando.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                comando.Parameters.AddWithValue("@NombreUsuario", cliente.NombreUsuario);
                comando.Parameters.AddWithValue("@Contraseña", cliente.Contraseña);
                comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                comando.Parameters.AddWithValue("@Direccion)", cliente.Direccion);
                comando.ExecuteNonQuery();
            }
        }
        public Cliente Buscar(string numeroDocumento)
        {
            using (var Comando = connection.CreateCommand())
            {
                Comando.CommandText = "Select * from Cliente where NumeroDocumento =@NumeroDocumento";
                Comando.Parameters.AddWithValue("@NumeroDocumento", numeroDocumento);
                var Reader = Comando.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        Cliente cliente = new Cliente();
                        cliente = Mapear(Reader);
                        return cliente;
                    }
                }
            }
            return null;
        }
        

        public Cliente Mapear(SqlDataReader reader)
        {
            Cliente cliente = new Cliente();
            cliente.TipoDocumento = (string)reader["tipoDocumento"];
            cliente.NumeroDocumento = (string)reader["numeroDocumento"];
            cliente.Nombre = (string)reader["nombre"];
            cliente.Apellido = (string)reader["apellido"];
            cliente.NombreUsuario = (string)reader["nombreUsuario"];
            cliente.Contraseña = (string)reader["contraseña"];
            cliente.Telefono = (string)reader["telefono"];
            cliente.Direccion = (string)reader["direccion"];
            

            return cliente;
        }

        public void Eliminar(string numeroDocumento)
        {
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "Delete from Cliente where NumeroDocumento = @NumeroDocumento";
                comando.Parameters.AddWithValue("@@NumeroDocumento", numeroDocumento);
                comando.ExecuteNonQuery();
            }

        }


        public List<Cliente> Consultar()
        {
            clientes.Clear();
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "Select * from Cliente";
                var Reader = comando.ExecuteReader();
                while (Reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente = Mapear(Reader);
                    clientes.Add(cliente);

                }
            }
            return clientes;
        }
        

        public void Modificar(Cliente cliente)
        {
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "UPDATE Cliente SET TipoDocumento=@TipoDocumento,Nombre=@Nombre,Apellido=@Apellido,NombreUsuario= @NombreUsuario,Contraseña=@Contraseña,Telefono=@Telefono,Direccion=@Direccion where NumeroDocumento = @NumeroDocumento";
                comando.Parameters.AddWithValue("@TipoDocumento", cliente.TipoDocumento);
                comando.Parameters.AddWithValue("@NumeroDocumento", cliente.NumeroDocumento);
                comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                comando.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                comando.Parameters.AddWithValue("@NombreUsuario", cliente.NombreUsuario);
                comando.Parameters.AddWithValue("@Contraseña", cliente.Contraseña);
                comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                comando.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                comando.ExecuteNonQuery();
            }
        }

        public List<Cliente> BuscarContiene(string nombre)
        {
            clientes = Consultar();
            return clientes.Where(p => p.Nombre.Contains(nombre)).ToList();
        }
       

        public int TotalClientes()
        {
            clientes = Consultar();
            return clientes.Count();
        }

    }
}
