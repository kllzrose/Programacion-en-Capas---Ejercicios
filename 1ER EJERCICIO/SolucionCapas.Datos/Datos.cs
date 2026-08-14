using System.Collections.Generic;
using System.Linq;

namespace Ejercicio1.Datos
{
    public class ProductoDatos
    {
        private List<(string Codigo, string Nombre, string Precio)> _tablaProductos = new List<(string, string, string)>
        {
            ("PROD-101", "Remera", "$100"),
            ("PROD-102", "Campera", "$350"),
            ("PROD-103", "Zapatillas", "$500")
        };

        public (string Codigo, string Nombre, string Precio)? BuscarPorCodigo(string codigo)
        {
            var resultado = _tablaProductos.FirstOrDefault(p => p.Codigo == codigo);
            if (resultado.Codigo == null) return null;
            return resultado;
        }
    }
}