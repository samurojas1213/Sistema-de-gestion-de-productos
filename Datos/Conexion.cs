using Microsoft.Data.SqlClient;

namespace SistemaGestionProductos.Datos
{
    public static class Conexion
    {
        private static readonly string cadena =
            "Server=.\\SQLEXPRESS;Database=GestionProductosDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadena);
        }
    }
}