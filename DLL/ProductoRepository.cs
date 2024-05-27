using ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class ProductoRepository
    {
        SqlConnection connection;
        List<Producto> productos;
        public ProductoRepository(ConexionDbDCostaFood Connection)
        {
            connection = Connection.connection;
            productos = new List<Producto>();
        }

        public void GuardarProducto(Producto producto)
        {
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "INSERT INTO Producto (Fecha,CodigoProducto,NombreProducto,TIpo,Presentacion,Precio)" +
                 "VALUES(@Fecha,@CodigoProducto,@NombreProducto,@TIpo,@Presentacion,@Precio)";
                comando.Parameters.AddWithValue("@Fecha", producto.Fecha.ToShortDateString());
                comando.Parameters.AddWithValue("@CodigoProducto", producto.CodigoProducto);
                comando.Parameters.AddWithValue("@NombreProducto", producto.Nombre);
                comando.Parameters.AddWithValue("@TIpo", producto.TipoProducto);
                comando.Parameters.AddWithValue("@Presentacion", producto.Presentacion);
                comando.Parameters.AddWithValue("@Precio", producto.Precio);
                comando.ExecuteNonQuery();
            }
        }

        public Producto Buscar(string codigo)
        {
            using (var Comando = connection.CreateCommand())
            {
                Comando.CommandText = "Select * from Producto where CodigoProducto =@CodigoProducto";
                Comando.Parameters.AddWithValue("@CodigoProducto", codigo);
                var Reader = Comando.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        Producto producto = new Producto();
                        producto = Mapear(Reader);
                        return producto;
                    }
                }
            }
            return null;
        }
        public Producto Mapear(SqlDataReader reader)
        {
            Producto producto = new Producto();
            producto.Fecha = Convert.ToDateTime((string)reader["Fecha"]);
            producto.CodigoProducto = (string)reader["CodigoProducto"];
            producto.Nombre = (string)reader["NombreProducto"];
            producto.TipoProducto = (string)reader["TIpo"];
            producto.Presentacion = (string)reader["Presentacion"];
            producto.Precio = (double)reader["Precio"];

            return producto;
        }

        public void Eliminar(string Codigo)
        {
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "Delete from Producto where CodigoProducto = @CodigoProducto";
                comando.Parameters.AddWithValue("@CodigoProducto", Codigo);
                comando.ExecuteNonQuery();
            }

        }

        public void Modificar(Producto producto)
        {
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "UPDATE Producto SET Fecha=@Fecha,NombreProducto=@NombreProducto,TIpo=@TIpo,Presentacion=@Presentacion,Precio=@Precio WHERE CodigoProducto=@CodigoProducto ";
                comando.Parameters.AddWithValue("@Fecha", producto.Fecha.ToShortDateString());
                comando.Parameters.AddWithValue("@CodigoProducto", producto.CodigoProducto);
                comando.Parameters.AddWithValue("@NombreProducto", producto.Nombre);
                comando.Parameters.AddWithValue("@TIpo", producto.TipoProducto);
                comando.Parameters.AddWithValue("@Presentacion", producto.Presentacion);
                comando.Parameters.AddWithValue("@Precio", producto.Precio);
                comando.ExecuteNonQuery();

            }
        }

        public List<Producto> Consultar()
        {
            productos.Clear();
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "Select * from Producto";
                var Reader = comando.ExecuteReader();
                while (Reader.Read())
                {
                    Producto producto = new Producto();
                    producto = Mapear(Reader);
                    productos.Add(producto);

                }
            }
            return productos;
        }

    }
}