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
    public class ServicioCliente
    {
        static ClienteRepository clienteRepository; 
        ConexionDbDCostaFood conexion;
        private List<Cliente> _clienteList;
        public ServicioCliente() 
        {
            clienteRepository = new ClienteRepository(conexion);
            _clienteList = new List<Cliente>();
        }
        public string GuardarCliente ( Cliente cliente)
        {
            try
            {
                if(clienteRepository.BuscarPorNombreUsuario(cliente.NombreUsuario)== null)
                {
                    clienteRepository.GuardarCliente(cliente);
                    return $"Se ha guardado correctamente tus datos {cliente.Nombre}";
                }
                else
                {
                    return $"¡El nombre de usario registrado ya existe, Intenta nuevamente con otro";
                }
            }
            catch (Exception e)
            {

                return $"Error en la aplicacion {e.Message}";
            }
            
            
        }





    }
}
