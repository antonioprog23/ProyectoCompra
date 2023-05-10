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

        public static List<Direccion> consusltarDireccion(int idUsuario)
        {
            List<Direccion> direcciones = new List<Direccion>();
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
                            Direccion direccion = new Direccion(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8));
                            direcciones.Add(direccion);
                        }
                    }
                }
            }
            return direcciones;
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
                            cmd.Parameters.AddWithValue("@Id_Direccion", direccion.idDireccion);
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

        public static bool eliminarDireccion(Direccion direccion)
        {
            bool eliminado = false;
            using (SqlConnection connection = new SqlConnection(RUTA_DB))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    using (SqlCommand cmd = new SqlCommand("EliminarDireccion", connection, transaction))
                    {
                        try
                        {
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Id_Direccion", direccion.idDireccion);
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
