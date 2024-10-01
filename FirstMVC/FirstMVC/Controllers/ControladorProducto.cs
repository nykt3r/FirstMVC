using FirstMVC.Models;
using FirstMVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMVC.Controllers
{
    public class ControladorProducto
    {
        private List<Producto> productos = new List<Producto>();
        private VistaProducto vista = new VistaProducto();

        public void AgregarProducto()
        {
            var detallesProducto = vista.ObtenerDetallesProducto();
            Producto producto = new Producto(detallesProducto.id, detallesProducto.nombre, detallesProducto.precio);
            productos.Add(producto);
            vista.MostrarMensaje("¡Producto agregado con éxito!");
        }

        public void MostrarProductos()
        {
            if (productos == null || productos.Count == 0)
            {
                vista.MostrarMensaje("No existen productos registrados.");
                return;
            } 

            List<string> productosInfo = new List<string>();
            foreach (var producto in productos)
            {
                productosInfo.Add($"ID: {producto.Id}, Nombre: {producto.Nombre}, Precio: {producto.Precio}");
            }

            vista.MostrarProductos(productosInfo);
        }

        public void EliminarProducto()
        {
            int id = vista.ObtenerIdProducto();
            Producto productoAEliminar = productos.Find(p => p.Id == id);

            if (productoAEliminar != null)
            {
                productos.Remove(productoAEliminar);
                vista.MostrarMensaje("¡Producto eliminado con éxito!");
            }
            else
            {
                vista.MostrarMensaje("Producto no encontrado.");
            }
        }
    }
}