using DLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioRepartidor
    {
        static RepartidorRepository repartidorRepository;
        static ConexionDbDCostaFood conexion;
        public ServicioRepartidor()
        {
            repartidorRepository = new ClienteRepository(conexion);
        }
        public string GuardarRepartidor(Repartidor repartidor)
        {
            try
            {
                if (repartidorRepository.BuscarPorNombreUsuario(repartidor.NombreUsuario) == null)
                {
                    repartidorRepository.GuardarRepartidor(repartidor);
                    return $"Se ha guardado correctamente los datos de {repartidor.Nombre}";
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

        public string EliminarRepartidor(string numeroDocumento)
        {
            try
            {
                if (repartidorRepository.BuscarPorNumDocumento(numeroDocumento) != null)
                {
                    repartidorRepository.Eliminar(numeroDocumento);
                    return ($"Se ha Eliminado Correctamente el repartidor");

                }
                else
                {
                    return ($"No se encuentra este repartidor registrado");
                }
            }
            catch (Exception e)
            {

                return $"Error en la aplicacion {e.Message}";
            }
        }
        public string ActualizarRepartidor(string numeroDocumento)
        {
            try
            {
                if (repartidorRepository.BuscarPorNumDocumento(numeroDocumento) != null)
                {
                    repartidorRepository.ActualizarRepartidor(numeroDocumento);
                    return $"Se ha Actualizado Correctamente el repartidor";
                }
                else
                {
                    return $"No se encuentra este repartidor registrado";
                }
            }
            catch (Exception e)
            {
                return $"Errror en la aplicacion {e.Message}";

            }
        }
    }
}
