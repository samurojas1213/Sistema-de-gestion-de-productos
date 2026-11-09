namespace SistemaGestionProductos.Modelos
{
    public class Categoria
    {
        private int idCategoria;
        private string nombre;
        private string descripcion;

        public int IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value?.Trim(); }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value?.Trim(); }
        }
    }
}