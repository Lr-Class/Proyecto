using DLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClsServicioCliente
    {
        //public ClsServicioCliente() 
        //{ 

        //}
        //public static string RegistroCliente (string tipoDocumento, string numeroDocumento, string nombre, string apellido, string nombreUsuario, string contraseña)
        //{
        //    ClsCliente cliente = new ClsCliente (tipoDocumento,numeroDocumento,nombre,apellido,nombreUsuario,contraseña);

        //}
        //public static DataTable RegistroCliente ( ClsCliente cliente)
        //{
        //    DataTable datosClientes = new DataTable();

        //}


        private ConexionDbDCostaFood conexion;
            
        private ClienteRepository clienteRepository;
        List<ClsCliente> clientes;
        ClsCliente cliente;

        public ClsServicioCliente(string connectionString)
        {
            conexion = new ConexionDbDCostaFood(connectionString);

            clienteRepository = new ClienteRepository(conexion);
        }

        public string GuardarCliente(ClsCliente cliente)
        {
            try
            {
                conexion.Open();

                clienteRepository.GuardarCliente(cliente);

                return $"Los datos del cliente  {cliente.Nombre} han sido guardados satiafactoriamente";
            }
            catch (Exception e)
            {
                return $"Error de base de datos: {e.Message}";
            }
            finally
            {
                conexion.Close();
            }

        }
    }
}
