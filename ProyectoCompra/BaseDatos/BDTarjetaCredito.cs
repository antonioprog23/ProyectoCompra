using ProyectoCompra.Clases;
using System.Data.SqlClient;

namespace ProyectoCompra.Base_datos
{
    public class BDTarjetaCredito
    {
        //CONSTANTES
        private const string RUTA_DB = "Data Source=ANTONIO\\SQLEXPRESS;Initial Catalog=EasyShop;Integrated Security=True;";

        public static bool actualizarTarjetaCredito(TarjetaCredit tarjetaCredito)
        {
            bool insertado = false;
            using (SqlConnection connection = new SqlConnection(RUTA_DB))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    using (SqlCommand cmd = new SqlCommand("ActualizarTarjeta", connection, transaction))
                    {
                        try
                        {
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Id_Usuario", tarjetaCredito.idUsusario);
                            cmd.Parameters.AddWithValue("@Titular", tarjetaCredito.titular);
                            cmd.Parameters.AddWithValue("@Numero_Tarjeta", tarjetaCredito.numerosTarjeta);
                            cmd.Parameters.AddWithValue("@Mes_Vencimiento", tarjetaCredito.mesVencimiento);
                            cmd.Parameters.AddWithValue("@Anio_Vencimiento", tarjetaCredito.anioVencimiento);
                            cmd.Parameters.AddWithValue("@CVV", tarjetaCredito.cvv);
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

        public static bool eliminarTarjetaCredito(int idUsuario)
        {
            bool eliminado = false;
            using (SqlConnection connection = new SqlConnection(RUTA_DB))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    using (SqlCommand cmd = new SqlCommand("EliminarTarjetaCredito", connection, transaction))
                    {
                        try
                        {
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Id_Usuario", idUsuario);
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

        public static TarjetaCredit consultarTarjetaCredito(int idUsuario)
        {
            TarjetaCredit tarjetaCredit = null;
            using (SqlConnection connection = new SqlConnection(RUTA_DB))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("ConsultarTarjetaCredito", connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id_Usuario", idUsuario);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tarjetaCredit = new TarjetaCredit(idUsuario, reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                        }
                    }

                }
            }
            return tarjetaCredit;
        }
    }
}
