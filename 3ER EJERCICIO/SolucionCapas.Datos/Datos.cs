using System.Collections.Generic;
using System.Linq;

namespace Ejercicio3.Datos
{
    public class VehiculoDatos
    {
        private List<(string Patente, string Modelo, bool TieneDeuda)> _tablaVehiculos = new List<(string, string, bool)>
        {
            ("N1GG3R", "Volkswagen Gol", false),
            ("S3NT3Y", "Ford Focus", true),
            ("H3NT4Y", "Renault Clio", false)
        };

        public (string Patente, string Modelo, bool TieneDeuda)? BuscarPorPatente(string patente)
        {
            var resultado = _tablaVehiculos.FirstOrDefault(v => v.Patente.ToUpper() == patente.ToUpper());
            if (resultado.Patente == null) return null;
            return resultado;
        }
    }
}