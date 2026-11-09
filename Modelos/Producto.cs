namespace SistemaGestionProductos.Modelos
{
    public class Producto
    {
        private int idProducto;
        private string nombre;
        private decimal precio;
        private int stock;
        private DateTime fechaRegistro;
        private int idCategoria;

        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value?.Trim(); }
        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public DateTime FechaRegistro
        {
            get { return fechaRegistro; }
            set { fechaRegistro = value; }
        }

        public int IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }

        // Solo para mostrar en el DataGridView (viene del JOIN con Categorias)
        public string NombreCategoria { get; set; }

        // RF-06: se calcula en la aplicación, NO se guarda en la base de datos
        public decimal ValorInventario
        {
            get { return Precio * Stock; }
        }
    }
}