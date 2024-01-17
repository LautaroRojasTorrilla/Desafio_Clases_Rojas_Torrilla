using Models;

namespace Desafio_Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto Producto
            Producto miProducto = new Producto(1, "Laptop", 800, 1200, 10, 123);

            // Mostrar los datos del producto
            Console.WriteLine("Datos del Producto:\n");
            Console.WriteLine(miProducto.MostrarDatos());

            // Modificar algunos valores
            miProducto.Stock = 8;
            miProducto.PrecioVenta = 1300;

            // Mostrar los datos actualizados
            Console.WriteLine("Datos del Producto Actualizados:\n");
            Console.WriteLine(miProducto.MostrarDatos());

            Console.ReadKey();
        }
    }
}