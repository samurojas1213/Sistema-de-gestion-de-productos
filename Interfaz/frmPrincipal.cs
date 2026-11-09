using Sistema_de_gestion_de_productos.Interfaz;

namespace Sistema_de_gestion_de_productos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCategorias_Click_1(object sender, EventArgs e)
        {
            new frmCategorias().ShowDialog();
        }

        private void btnProductos_Click_1(object sender, EventArgs e)
        {
            new frmProductos().ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

    }

}
