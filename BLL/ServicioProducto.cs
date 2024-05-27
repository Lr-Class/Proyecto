
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal class ServicioProducto
    {
﻿using DLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static ENTITY.ProductoResponse;

namespace BLL
{
    public class ServicioProducto
    {
        public static ProductoRepository productoRepository;
        public static ConexionDbDCostaFood conexion;
        public List<Producto> productos { get; set; }
        
        public ServicioProducto() 
        {
            productoRepository = new ProductoRepository(conexion);
        }
        public string GuardarProducto(Producto producto)
        {
            try
            {
                if (productoRepository.BuscarPorCodigoProducto(producto.CodigoProducto) == null)
                {
                    productoRepository.GuardarProducto(producto);
                    return $"Se ha guardado correctamente {producto.Nombre}";
                }
                else
                {
                    return $"¡El producto con el codigo {producto.CodigoProducto} ya existe, Intenta nuevamente con otro";
                }
            }
            catch (Exception e)
            {

                return $"Error en la aplicacion {e.Message}";
            }


        }
        public string EliminarProducto(string codigoProducto)
        {
            try
            {
                if(productoRepository.BuscarPorCodigoProducto(codigoProducto) != null) 
                {
                    productoRepository.EliminarProducto(codigoProducto);
                    return $"Se ha eliminad Correctamente el producto";
                }
                else
                {
                    return $"No se encuentra este producto registrado";
                }
            }
            catch (Exception e)
            {
                return $"Errror en la aplicacion {e.Message}";
                
            }
        }
        public string ActualizarProducto (string codigoProducto)
        {
            try
            {
                if (productoRepository.BuscarPorCodigoProducto(codigoProducto) != null)
                {
                    productoRepository.ActualizarProducto(codigoProducto);
                    return $"Se ha Actualizado Correctamente el producto";
                }
                else
                {
                    return $"No se encuentra este producto registrado";
                }
            }
            catch (Exception e)
            {
                return $"Errror en la aplicacion {e.Message}";

            }
        }
        public List<Producto> MostrarProductor()
        {
            productos = productoRepository.ConsultarProductos();
            return productos;
        }
        public ConsultarProductoResponse ConsultarProductos()
        {
            try
            {
                List<Producto> productos = productoRepository.ConsultarProductos();
                if (productos != null)
                {
                    return new ConsultarProductoResponse(productos);
                }
                else
                {
                    return new ConsultarProductoResponse("El producto buscado no se encuentra Registrado");
                }
            }
            catch (Exception)
            {

                return new ConsultarProductoResponse($"Error en la aplicacion: {e.Message}");
            }
        }
      


    }
}
