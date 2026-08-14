using System;
using Ejercicio2.Negocio;
 
namespace Ejercicio2.Presentacion
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese el número de Legajo (ej: 10042): ");
            if (int.TryParse(Console.ReadLine(), out int legajo))
            {
                AlumnoNegocio negocio = new AlumnoNegocio();
                Alumno alumno = negocio.ObtenerAlumno(legajo);

                if (alumno != null)
                    Console.WriteLine($"Encontrado -> Alumno: {alumno.Nombre}, Condición: {alumno.Condicion}");
                else
                    Console.WriteLine("No existe el alumno o el legajo debe ser mayor a cero.");
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
            }
        }
    }
}