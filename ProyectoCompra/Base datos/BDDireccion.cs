using ProyectoCompra.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCompra.Base_datos
{
    internal class BDDireccion
    {
        //CONSTANTES
        private const string RUTA_DB = "Data Source=ANTONIO\\SQLEXPRESS;Initial Catalog=EasyShop;Integrated Security=True;";

        public static Direccion consusltarDireccion(int idUsuario)
        {
            Direccion direccion = null;
            using (SqlConnection connection = new SqlConnection(RUTA_DB))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("ConsultarDireccion", connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id_Usuario", idUsuario);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            direccion = new Direccion(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8));
                        }
                    }
                }
            }
            return direccion;
        }

        public static bool actualizarDireccion(Direccion direccion, int idUsuario)
        {
            bool actualizado = false;
            using (SqlConnection connection = new SqlConnection(RUTA_DB))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    using (SqlCommand cmd = new SqlCommand("ActualizarDireccion", connection, transaction))
                    {
                        try
                        {
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Id_Usuario", idUsuario);
                            cmd.Parameters.AddWithValue("@Nombre_Direccion", direccion.nombre);
                            cmd.Parameters.AddWithValue("@Direccion", direccion.direccion);
                            cmd.Parameters.AddWithValue("@Pais", direccion.pais);
                            cmd.Parameters.AddWithValue("@Provincia", direccion.provincia);
                            cmd.Parameters.AddWithValue("@Ciudad", direccion.ciudad);
                            cmd.Parameters.AddWithValue("@Codigo_Postal", direccion.codigoPostal);
                            cmd.Parameters.AddWithValue("@Telefono", direccion.telefono);
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
