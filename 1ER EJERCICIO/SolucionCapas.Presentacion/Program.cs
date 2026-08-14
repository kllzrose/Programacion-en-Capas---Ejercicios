using System;
using Ejercicio1.Negocio;

namespace Ejercicio1.Presentacion
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese Código de Producto (ej: PROD-101): ");
            string codigo = Console.ReadLine();

            ProductoNegocio negocio = new ProductoNegocio();
            Producto producto = negocio.ObtenerProducto(codigo);

            if (producto != null)
                Console.WriteLine($"Encontrado -> Nombre: {producto.Nombre}, Precio: {producto.Precio}");
            else
                Console.WriteLine("No existe o el código es inválido (debe comenzar con 'PROD-').");
        }
    }
}