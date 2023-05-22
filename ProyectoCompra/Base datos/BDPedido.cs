using ProyectoCompra.Clases;
using System.Data.SqlClient;

namespace ProyectoCompra.Base_datos
{
    internal class BDPedido
    {
        //CONSTANTES
        private const string RUTA_DB = "Data Source=ANTONIO\\SQLEXPRESS;Initial Catalog=EasyShop;Integrated Security=True;";

        public static bool actualizarPedido(int idUsuario)
        {
            bool actualizado = false;
            using (SqlConnection connection = new SqlConnection(RUTA_DB))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    using (SqlCommand cmd = new SqlCommand("ActualizarPedido", connection, transaction))
                    {
                        try
                        {
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Id_Usuario", idUsuario);
                            cmd.ExecuteNonQuery();
                            transaction.Commit();
                            actualizado = true;
                        }
                        catch (SqlException)
                        {
                            actualizado = false;
                            transaction.Rollback();
                        }
                    }
                }
            }
            return actualizado;
        }
    }
}
