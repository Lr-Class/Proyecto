using ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Security.Claims;
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
                comando.CommandText = "INSERT INTO Cliente (Fecha,TipoDocumento,NumeroDocumento,Nombre,Apellido,NombreUsuario,Clave,Direccion,Telefono,Correo,NombreNegocio)" +
                "VALUES(@Fecha,@TipoDocumento,@NumeroDocumento,@Nombre,@Apellido,@NombreUsuario,@Clave,@Direccion,@Telefono,@Correo,@NombreNegocio)";
                comando.Parameters.AddWithValue("@Fecha", cliente.Fecha.ToShortDateString());
                comando.Parameters.AddWithValue("@TipoDocumento", cliente.TipoDocumento);
                comando.Parameters.AddWithValue("@NumeroDocumento", cliente.NumeroDocumento);
                comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                comando.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                comando.Parameters.AddWithValue("@NombreUsuario", cliente.NombreUsuario);
                comando.Parameters.AddWithValue("@Clave", cliente.Clave);
                comando.Parameters.AddWithValue("@Direccion)", cliente.Direccion);
                comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                comando.Parameters.AddWithValue("@Correo", cliente.Email);
                comando.Parameters.AddWithValue("@NombreNegocio", cliente.NombreNegocio);
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
<<<<<<< HEAD
            cliente.Fecha = Convert.ToDateTime((string)reader["fecha"]);
=======
>>>>>>> cb387a640572a7c39f00a0674fa286879e238c7d
            cliente.TipoDocumento = (string)reader["tipoDocumento"];
            cliente.NumeroDocumento = (string)reader["numeroDocumento"];
            cliente.Nombre = (string)reader["nombre"];
            cliente.Apellido = (string)reader["apellido"];
            cliente.NombreUsuario = (string)reader["nombreUsuario"];
            cliente.Clave = (string)reader["clave"];
            cliente.Direccion = (string)reader["direccion"];
            cliente.Telefono = (string)reader["telefono"];
           cliente.Email = new MailAddress((string)reader["correo"]);
            cliente.NombreNegocio = (string)reader["nombreNegocio"];

            return cliente;
        }

        public void Eliminar(string numeroDocumento)
        {
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "Delete from Cliente where NumeroDocumento = @NumeroDocumento";
                comando.Parameters.AddWithValue("@NumeroDocumento", numeroDocumento);
                comando.ExecuteNonQuery();
            }

        }

<<<<<<< HEAD
=======

>>>>>>> cb387a640572a7c39f00a0674fa286879e238c7d
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
        

<<<<<<< HEAD
        public Cliente BuscarPorNombreUsuario(string nombreUsuario)
        {
            using (var Comando = connection.CreateCommand())
            {
                Comando.CommandText = "Select * from Cliente where NombreUsuario = @NombreUsuario";
                Comando.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
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

=======
>>>>>>> cb387a640572a7c39f00a0674fa286879e238c7d
        public void Modificar(Cliente cliente)
        {
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "UPDATE Cliente SET Fecha=@Fecha,TipoDocumento=@TipoDocumento,Nombre=@Nombre,Apellido=@Apellido,NombreUsuario=@NombreUsuario,Clave=@Clave,Direccion=@Direccion,Telefono=@Telefono,Correo=@Correo,NombreNegocio=@NombreNegocio WHERE NumeroDocumento = @NumeroDocumento";
                comando.Parameters.AddWithValue("@Fecha", cliente.Fecha.ToShortDateString());
                comando.Parameters.AddWithValue("@TipoDocumento", cliente.TipoDocumento);
                comando.Parameters.AddWithValue("@NumeroDocumento", cliente.NumeroDocumento);
                comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                comando.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                comando.Parameters.AddWithValue("@NombreUsuario", cliente.NombreUsuario);
                comando.Parameters.AddWithValue("@Clave", cliente.Clave);
                comando.Parameters.AddWithValue("@Direccion)", cliente.Direccion);
                comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                comando.Parameters.AddWithValue("@Correo", cliente.Email);
                comando.Parameters.AddWithValue("@NombreNegocio", cliente.NombreNegocio);
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
