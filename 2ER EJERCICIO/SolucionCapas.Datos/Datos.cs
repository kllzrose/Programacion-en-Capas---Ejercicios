using System.Collections.Generic;
using System.Linq;

namespace Ejercicio2.Datos
{
    public class AlumnoDatos
    {
        private List<(int Legajo, string Nombre, string Condicion)> _tablaAlumnos = new List<(int, string, string)>
        {
            (10042, "Lucía Gómez", "Aprobado"),
            (10043, "Carlos Pérez", "Regular"),
            (10044, "Ana Torres", "Libre")
        };

        public (int Legajo, string Nombre, string Condicion)? BuscarPorLegajo(int legajo)
        {
            var resultado = _tablaAlumnos.FirstOrDefault(a => a.Legajo == legajo);
            if (resultado.Legajo == 0) return null;
            return resultado;
        }
    }
}