using FirstMVC.Controllers;

namespace FirstMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            ControladorProducto controlador = new ControladorProducto();
            bool ejecutando = true;

            while (ejecutando)
            {
                Console.WriteLine("1. Agregar Producto");
                Console.WriteLine("2. Mostrar Productos");
                Console.WriteLine("3. Eliminar Producto");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        controlador.AgregarProducto();
                        break;
                    case "2":
                        controlador.MostrarProductos();
                        break;
                    case "3":
                        controlador.EliminarProducto();
                        break;
                    case "4":
                        ejecutando = false;
                        break;
                    default:
                        Console.WriteLine("Opción inválida, por favor intente nuevamente.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}