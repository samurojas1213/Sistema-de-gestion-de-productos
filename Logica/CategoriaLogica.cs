using SistemaGestionProductos.Datos;
using SistemaGestionProductos.Modelos;

namespace SistemaGestionProductos.Logica
{
    public static class CategoriaLogica
    {
        public static string ValidarNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                return "El nombre es obligatorio.";
            return null;
        }

        public static void Guardar(Categoria categoria)
        {
            CategoriaDatos.Insertar(categoria);
        }

        public static void Modificar(Categoria categoria)
        {
            CategoriaDatos.Actualizar(categoria);
        }

        public static void Eliminar(int idCategoria)
        {
            CategoriaDatos.Eliminar(idCategoria);
        }

        public static List<Categoria> Listar()
        {
            return CategoriaDatos.Listar();
        }
    }
}