using Ejercicio3.Datos;

namespace Ejercicio3.Negocio
{
    public class Vehiculo
    {
        public string Patente { get; set; }
        public string Modelo { get; set; }
        public bool TieneDeuda { get; set; }
    }

    public class VehiculoNegocio
    {
        private VehiculoDatos _datos = new VehiculoDatos();

        public Vehiculo ObtenerVehiculo(string patente)
        {
            if (string.IsNullOrEmpty(patente) || patente.Length < 6)
                return null;

            var resultado = _datos.BuscarPorPatente(patente);
            if (resultado == null) return null;

            return new Vehiculo { Patente = resultado.Value.Patente, Modelo = resultado.Value.Modelo, TieneDeuda = resultado.Value.TieneDeuda };
        }
    }
}