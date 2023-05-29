using ProyectoCompra.Clases;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProyectoCompra.Base_datos
{
    internal class BDCarrito
    {
        //CONSTANTES
        private const string RUTA_DB = "Data Source=ANTONIO\\SQLEXPRESS;Initial Catalog=EasyShop;Integrated Security=True;";

        public static bool insertarProductoCarrito(params object[] data)
        {
            bool insertado = false;
            using (SqlConnection connection = new SqlConnection(RUTA_DB))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    using (SqlCommand cmd = new SqlCommand("InsertarProductoCarrito", connection, transaction))
                    {
                        try
                        {
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Id_Usuario", (data[0] as Usuario).idUsuario);
                            cmd.Parameters.AddWithValue("@Id_Producto", (data[1] as Carrito).producto.id_producto);
                            cmd.Parameters.AddWithValue("@Cantidad", (data[1] as Carrito).cantidad);
                            cmd.Parameters.AddWithValue("@Aumentar", data[2]);
                            cmd.ExecuteNonQuery();
                            transaction.Commit();
                            insertado = true;
                        }
                        catch (SqlException)
                        {
                            insertado = false;
                            transaction.Rollback();
                        }
                    }
                }
            }
            return insertado;
        }

        public static List<Carrito> consultarCarrito(int id)
        {
            List<Carrito> lista = new List<Carrito>();
            using (SqlConnection connection = new SqlConnection(RUTA_DB))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("ConsultarProductoCarrito", connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id_Usuario", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Producto producto = new Producto(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDecimal(3), reader.GetString(4));
                            int cantidad = reader.GetInt32(5);
                            string rutaImagen = reader.GetString(6);
                            Carrito c = new Carrito(cantidad, producto, rutaImagen);
                            lista.Add(c);
                        }
                        return lista;
                    }
                }
            }
        }

        public static bool vaciarCarrito(int idUsuario, int idProducto, bool eliminarTodo)
        {
            bool eliminado = false;
            using (SqlConnection connection = new SqlConnection(RUTA_DB))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    using (SqlCommand cmd = new SqlCommand("EliminarProductoCarrito", connection, transaction))
                    {
                        try
                        {
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Id_Usuario", idUsuario);
                            cmd.Parameters.AddWithValue("@Id_Producto", idProducto);
                            cmd.Parameters.AddWithValue("@Vaciar_Todo", eliminarTodo);
                            cmd.ExecuteNonQuery();
                            transaction.Commit();
                            eliminado = true;
                        }
                        catch (SqlException)
                        {
                            eliminado = false;
                            transaction.Rollback();
                        }
                    }
                }
            }
            return eliminado;
        }

    }
}
