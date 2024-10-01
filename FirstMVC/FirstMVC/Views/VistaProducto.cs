using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMVC.Views
{
    public class VistaProducto
    {
        public (int id, string nombre, decimal precio) ObtenerDetallesProducto()
        {
            Console.Write("Ingrese el ID del producto: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el nombre del producto: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el precio del producto: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            return (id, nombre, precio);
        }

        public int ObtenerIdProducto()
        {
            Console.Write("Ingrese el ID del producto a eliminar: ");
            return int.Parse(Console.ReadLine());
        }

        public void MostrarMensaje(string mensaje)
        {
            Console.WriteLine($"\n{mensaje}");
        }

        public void MostrarProductos(List<string> productos)
        {
            Console.WriteLine("\nLista de Productos:");
            foreach (var producto in productos)
            {
                Console.WriteLine(producto);
            }
            Console.WriteLine();
        }
    }
}