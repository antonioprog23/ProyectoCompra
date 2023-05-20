using ProyectoCompra.Clases;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProyectoCompra.Base_datos
{
    internal class BDProducto
    {
        //CONSTANTES
        private const string RUTA_DB = "Data Source=ANTONIO\\SQLEXPRESS;Initial Catalog=EasyShop;Integrated Security=True;";

        public static List<Producto> obtenerProductos(int subcategoria)
        {
            List<Producto> productos = new List<Producto>();
            using (SqlConnection connection = new SqlConnection(RUTA_DB))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("ConsultarProductos", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id_SubCategoria", subcategoria);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Producto producto = new Producto(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3),reader.GetDecimal(4), reader.GetString(5));
                            productos.Add(producto);
                        }
                    }
                }
            }
            return productos;
        }
    }
}
