using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;




namespace BLL
{
    public class ServicioPedido
    {
        public List<Producto> productos;
        static ProductoRepository productoRepository;
        public Dictionary<string, string> Cantidades { get; set; }  // Diccionario para almacenar CodigoProducto y Cantidad
        public ServicioPedido()
        {
            productoRepository = new ProductoRepository();
            productos = new List<Producto>();
            Cantidades = new Dictionary<string, string>();
        }
        public string GuardarPedido(Pedidos pedido)
        {
            try
            {
                productoRepository.GuardarPedido(pedido);
                return $"Se ha guardado correctamente el pedido con el código {pedido.Codigo}";
            }
            catch (Exception e)
            {

                return $"Error al guardar el pedido:{e.Message}" + "Error:" +   MessageBoxButton.OK;
            }
        }
       public List<Producto> ObtenerProductos(List<string> codigosProductos)
        {
            try
            {
                foreach (var codigo in productos)
                {
                    var producto = productoRepository.ObtenerProdcutoPorCodigo(codigo);
                    if (producto != null)
                    {
                        productos.Add(producto);
                    }
                   
                } 
            }
            
            catch (Exception e)
            {
                MessageBox.Show($"Error en la aplicacion {e.Message}");
                
            }

            return productos;

        }
        public Pedidos GuardarPedido(string codigoPedido, List<(string codigoProducto, int cantidad)>productosSeleccionados)
        {
            double totalPrecio = 0;
            try
            {
                foreach (var (codigoProducto, cantidad) in productosSeleccionados)
                {
                    var producto = productoRepository.ObtenerProductoPorCodigo(codigoProducto);
                    if (producto != null)
                    {
                        totalPrecio += producto.Precio * cantidad;
                        for (int i = 0; i < cantidad; i++)
                        {
                            productos.Add(producto);
                        }
                    }
                }
                var pedido = new Pedidos
                {
                    Codigo = codigoPedido,
                    EstadoPedido = "Pendiente",
                    FechaPedido = DateTime.Now
                };
                return pedido;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al crear el pedido: {e.Message}");
                
                throw;
            }
        }


    }
}
