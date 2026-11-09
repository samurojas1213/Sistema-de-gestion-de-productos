using Microsoft.Data.SqlClient;
using SistemaGestionProductos.Modelos;

namespace SistemaGestionProductos.Datos
{
    public static class ProductoDatos
    {
        // Si el filtro viene vacío trae todos; si no, busca por nombre (RF-04)
        public static List<Producto> Listar(string filtro = "")
        {
            var lista = new List<Producto>();
            using (var cn = Conexion.ObtenerConexion())
            {
                cn.Open();
                string sql = @"SELECT p.IdProducto, p.Nombre, p.Precio, p.Stock, p.FechaRegistro,
                                      p.IdCategoria, c.Nombre AS NombreCategoria
                               FROM Productos p
                               INNER JOIN Categorias c ON p.IdCategoria = c.IdCategoria
                               WHERE p.Nombre LIKE @filtro
                               ORDER BY p.Nombre";
                var cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Producto
                        {
                            IdProducto = dr.GetInt32(0),
                            Nombre = dr.GetString(1),
                            Precio = dr.GetDecimal(2),
                            Stock = dr.GetInt32(3),
                            FechaRegistro = dr.GetDateTime(4),
                            IdCategoria = dr.GetInt32(5),
                            NombreCategoria = dr.GetString(6)
                        });
                    }
                }
            }
            return lista;
        }

        public static void Insertar(Producto p)
        {
            using (var cn = Conexion.ObtenerConexion())
            {
                cn.Open();
                var cmd = new SqlCommand(
                    @"INSERT INTO Productos (Nombre, Precio, Stock, FechaRegistro, IdCategoria)
                      VALUES (@nombre, @precio, @stock, @fecha, @idCategoria)", cn);
                cmd.Parameters.AddWithValue("@nombre", p.Nombre);
                cmd.Parameters.AddWithValue("@precio", p.Precio);
                cmd.Parameters.AddWithValue("@stock", p.Stock);
                cmd.Parameters.AddWithValue("@fecha", p.FechaRegistro);
                cmd.Parameters.AddWithValue("@idCategoria", p.IdCategoria);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Actualizar(Producto p)
        {
            using (var cn = Conexion.ObtenerConexion())
            {
                cn.Open();
                var cmd = new SqlCommand(
                    @"UPDATE Productos SET Nombre=@nombre, Precio=@precio, Stock=@stock, IdCategoria=@idCategoria
                      WHERE IdProducto=@id", cn);
                cmd.Parameters.AddWithValue("@nombre", p.Nombre);
                cmd.Parameters.AddWithValue("@precio", p.Precio);
                cmd.Parameters.AddWithValue("@stock", p.Stock);
                cmd.Parameters.AddWithValue("@idCategoria", p.IdCategoria);
                cmd.Parameters.AddWithValue("@id", p.IdProducto);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Eliminar(int idProducto)
        {
            using (var cn = Conexion.ObtenerConexion())
            {
                cn.Open();
                var cmd = new SqlCommand("DELETE FROM Productos WHERE IdProducto=@id", cn);
                cmd.Parameters.AddWithValue("@id", idProducto);
                cmd.ExecuteNonQuery();
            }
        }
    }
}