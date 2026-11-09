using SistemaGestionProductos.Datos;
using SistemaGestionProductos.Modelos;

namespace SistemaGestionProductos.Logica
{
    public static class ProductoLogica
    {
        // Cada validación devuelve un mensaje de error, o null si todo está bien

        public static string ValidarNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                return "El nombre es obligatorio.";
            return null;
        }

        public static string ValidarPrecio(string texto, out decimal precio)
        {
            precio = 0;
            if (string.IsNullOrWhiteSpace(texto))
                return "El precio es obligatorio.";
            if (!decimal.TryParse(texto, out precio))
                return "El precio debe ser un número válido.";
            if (precio <= 0)
                return "El precio debe ser mayor que cero.";
            return null;
        }

        public static string ValidarStock(string texto, out int stock)
        {
            stock = 0;
            if (string.IsNullOrWhiteSpace(texto))
                return "El stock es obligatorio.";
            if (!int.TryParse(texto, out stock))
                return "El stock debe ser un número entero.";
            if (stock < 0)
                return "El stock no puede ser negativo.";
            return null;
        }

        public static string ValidarCategoria(object categoriaSeleccionada)
        {
            if (categoriaSeleccionada == null)
                return "Debe seleccionar una categoría.";
            return null;
        }

        public static void Guardar(Producto producto)
        {
            producto.FechaRegistro = DateTime.Now;   // RF-07: fecha automática
            ProductoDatos.Insertar(producto);
        }

        public static void Modificar(Producto producto)
        {
            ProductoDatos.Actualizar(producto);
        }

        public static void Eliminar(int idProducto)
        {
            ProductoDatos.Eliminar(idProducto);
        }

        public static List<Producto> Buscar(string filtro)
        {
            return ProductoDatos.Listar(filtro);
        }
    }
}