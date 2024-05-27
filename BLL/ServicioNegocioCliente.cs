using DLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioNegocioCliente
    {
        static NegocioRepository negocioRepository;
        static ConexionDbDCostaFood conexion;
        public ServicioNegocioCliente()
        {
            negocioRepository = new NegocioRepository(conexion); 
        }
        public string RegistroNegocio(NegocioCliente negocio, string resultado)
        {
            try
            {
                resultado = negocioRepository.Guardar(negocio);
                return resultado;
            }
            catch (Exception e)
            {

                return $"Error al guardar Negocio {e.Message}";
            }
        }

    }
}
