using ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{     public class FacturaRepository
    {
        SqlConnection connection;
        IList<Factura> facturas;
        public FacturaRepository(ConexionDbDCostaFood Connection)
        {
            connection = Connection.connection;
            facturas = new List<Factura>();
        }
        public void GuardarFactura(Factura factura)
        {
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "INSERT INTO Factura (FechaFactura,CodigoFactura,TipoDocumento,NumeroDocumentoC,NombreCliente,ApellidoCliente,NombreNegocio,Telefono,Correo,DireccionNegocio,SubTotalFactura,TotalIvaFactura,TotalFactura)" +
                       "VALUES(@FechaFactura,@CodigoFactura,@TipoDocumento,@NumeroDocumentoC,@NombreCliente,@ApellidoCliente,@NombreNegocio,@Telefono,@Correo,@DireccionNegocio,@SubTotalFactura,@TotalIvaFactura,@TotalFactura)";
                comando.Parameters.AddWithValue("@FechaFactura", factura.FechaFactura);
                comando.Parameters.AddWithValue("@CodigoFactura", factura.CodigoFactura);
                comando.Parameters.AddWithValue("@TipoDocumento", factura.TipoDocumento);
                comando.Parameters.AddWithValue("@NumeroDocumentoC", factura.NumeroDocumento);
                comando.Parameters.AddWithValue("@NombreCliente", factura.NombreCliente);
                comando.Parameters.AddWithValue("@ApellidoCliente", factura.ApellidoCliente);
                comando.Parameters.AddWithValue("@NombreNegocio", factura.NombreNegocio);
                comando.Parameters.AddWithValue("@Telefono", factura.Telefono);
                comando.Parameters.AddWithValue("@Correo", factura.Email);
                comando.Parameters.AddWithValue("@DireccionNegocio", factura.DireccionNegocio);
                comando.Parameters.AddWithValue("@SubTotalFactura", factura.SubTotalFactura);
                comando.Parameters.AddWithValue("@TotalIvaFactura", factura.TotalIvaFactura);
                comando.Parameters.AddWithValue("@TotalFactura", factura.TotalFactura);
                comando.ExecuteNonQuery();
            }
        }

        public Factura Buscar(string NumeroDocumento)
        {
            using (var Comando = connection.CreateCommand())
            {
                Comando.CommandText = "Select * from Factura where NumeroDocumentoC =@NumeroDocumentoC";
                Comando.Parameters.AddWithValue("@NumeroDocumentoC", NumeroDocumento);
                var Reader = Comando.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        Factura factura = new Factura();
                        factura = Mapear(Reader);
                        return factura;
                    }
                }
            }
            return null;

        }

        public Factura Mapear(SqlDataReader reader)
        {
            Factura factura = new Factura();
            factura.CodigoFactura = (string)reader["CodigoFactura"];
            factura.TipoDocumento = (string)reader["TipoDocumento"];
            factura.NumeroDocumento = (string)reader["NumeroDocumento)"];
            factura.NombreCliente = (string)reader["NombreCliente)"];
            factura.ApellidoCliente = (string)reader["ApellidoCliente)"];
            factura.NombreNegocio = (string)reader["NombreNegocio)"];
            factura.Telefono = (string)reader["Telefono)"];
            factura.Email = new MailAddress((string)reader["correo"]);
            factura.DireccionNegocio = (string)reader["DireccionNegocio)"];
           factura.SubTotalFactura = (double)reader["SubTotalFactura"];
            factura.TotalIvaFactura = (double)reader["TotalIvaFactura"];
            factura.TotalFactura = (double)reader["TotalFactura"];

            string fechaString = (string)reader["FechaFactura"];
            string formato = "MMM dd yyyy h:mmtt";

            Console.WriteLine("Cadena de fecha: " + fechaString);
            try
            {
                DateTime fecha = DateTime.ParseExact(fechaString, formato, CultureInfo.InvariantCulture);
                factura.FechaFactura = fecha;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error al analizar la fecha: " + ex.Message);
            }

            return factura;
        }

        public IList<Factura> Consultar()
        {
            facturas.Clear();
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "SELECT * FROM Factura";
                var Reader = comando.ExecuteReader();
                while (Reader.Read())
                {

                    Factura factura = Mapear(Reader);
                    facturas.Add(factura);

                }
            }
            return facturas;
        }

        public IList<Factura> BuscarContiene(string nombreCliente)
        {
            facturas = Consultar();
            return facturas.Where(p => p.NombreCliente.Contains(nombreCliente)).ToList();
        }

        public List<Factura> ListarFecha(DateTime fecha)
        {

            facturas = Consultar();
            return facturas.Where(p => p.FechaFactura.Equals(fecha)).ToList();
        }


    }
}
