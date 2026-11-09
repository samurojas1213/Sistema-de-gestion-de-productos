using Microsoft.Data.SqlClient;
using SistemaGestionProductos.Modelos;

namespace SistemaGestionProductos.Datos
{
    public static class CategoriaDatos
    {
        public static List<Categoria> Listar()
        {
            var lista = new List<Categoria>();
            using (var cn = Conexion.ObtenerConexion())
            {
                cn.Open();
                var cmd = new SqlCommand("SELECT IdCategoria, Nombre, Descripcion FROM Categorias ORDER BY Nombre", cn);
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Categoria
                        {
                            IdCategoria = dr.GetInt32(0),
                            Nombre = dr.GetString(1),
                            Descripcion = dr.IsDBNull(2) ? "" : dr.GetString(2)
                        });
                    }
                }
            }
            return lista;
        }

        public static void Insertar(Categoria c)
        {
            using (var cn = Conexion.ObtenerConexion())
            {
                cn.Open();
                var cmd = new SqlCommand("INSERT INTO Categorias (Nombre, Descripcion) VALUES (@nombre, @descripcion)", cn);
                cmd.Parameters.AddWithValue("@nombre", c.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", (object)c.Descripcion ?? DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Actualizar(Categoria c)
        {
            using (var cn = Conexion.ObtenerConexion())
            {
                cn.Open();
                var cmd = new SqlCommand("UPDATE Categorias SET Nombre=@nombre, Descripcion=@descripcion WHERE IdCategoria=@id", cn);
                cmd.Parameters.AddWithValue("@nombre", c.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", (object)c.Descripcion ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@id", c.IdCategoria);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Eliminar(int idCategoria)
        {
            using (var cn = Conexion.ObtenerConexion())
            {
                cn.Open();
                var cmd = new SqlCommand("DELETE FROM Categorias WHERE IdCategoria=@id", cn);
                cmd.Parameters.AddWithValue("@id", idCategoria);
                cmd.ExecuteNonQuery();
            }
        }
    }
}