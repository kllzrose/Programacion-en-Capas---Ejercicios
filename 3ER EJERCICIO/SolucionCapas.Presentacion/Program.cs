using System;
using Ejercicio3.Negocio;

namespace Ejercicio3.Presentacion
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese la Patente (ej: AA123CD): ");
            string patente = Console.ReadLine();

            VehiculoNegocio negocio = new VehiculoNegocio();
            Vehiculo vehiculo = negocio.ObtenerVehiculo(patente);

            if (vehiculo != null)
            {
                string deudaMsg = vehiculo.TieneDeuda ? "Sí" : "No";
                Console.WriteLine($"Modelo: {vehiculo.Modelo} | Deuda pendiente: {deudaMsg}");
            }
            else
            {
                Console.WriteLine("Vehículo no encontrado o la patente tiene menos de 6 caracteres.");
            }
        }
    }
}