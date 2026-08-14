using Ejercicio1.Datos;

namespace Ejercicio1.Negocio
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Precio { get; set; }
    }

    public class ProductoNegocio
    {
        private ProductoDatos _datos = new ProductoDatos();

        public Producto ObtenerProducto(string codigo)
        {
            if (string.IsNullOrEmpty(codigo) || !codigo.StartsWith("PROD-"))
                return null;

            var resultado = _datos.BuscarPorCodigo(codigo);
            if (resultado == null) return null;

            return new Producto { Codigo = resultado.Value.Codigo, Nombre = resultado.Value.Nombre, Precio = resultado.Value.Precio };
        }
    }
}