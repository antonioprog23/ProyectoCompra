using ProyectoCompra.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCompra.Base_datos
{
    internal class BDCliente
    {
        //CONSTANTES
        private const string RUTA_DB = "Data Source=ANTONIO\\SQLEXPRESS;Initial Catalog=Compras;Integrated Security=True;";
        public static bool insertarDatos(Cliente cliente, Usuario usuario)
        {
            bool insertado = true;
            using (SqlConnection connection = new SqlConnection(RUTA_DB))
            {
                connection.Open();
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("", connection))
                {
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        using (SqlCommand cmd = new SqlCommand("", connection, transaction))
                        {
                            try
                            {
                                cmd.CommandText = "InsertarDatos";
                                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                                //CLIENTE
                                cmd.Parameters.AddWithValue("@Nombre", cliente.nombre);
                                cmd.Parameters.AddWithValue("@Apellido", cliente.apellido);
                                cmd.Parameters.AddWithValue("@Edad", cliente.edad);
                                cmd.Parameters.AddWithValue("@Fecha_Nacimiento", cliente.fechaNacimiento);
                                cmd.Parameters.AddWithValue("@Sexo", cliente.sexo);
                                cmd.Parameters.AddWithValue("@Direccion", cliente.direccion);
                                cmd.Parameters.AddWithValue("@CorreoElectronico", cliente.correo);
                                //USUARIO
                                cmd.Parameters.AddWithValue("@Usuario_name", usuario.username);
                                cmd.Parameters.AddWithValue("@Contrasenia", usuario.password);
                                cmd.ExecuteNonQuery();
                                transaction.Commit();
                                insertado = true;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                transaction.Rollback();
                                insertado = false;
                            }
                        }
                    }
                }
            }
            return insertado;
        }


        public static Usuario obtenerDatos(int idUsario)
        {
            Usuario usuarioCompleto = null;
            using (SqlConnection connection = new SqlConnection(RUTA_DB))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("", connection))
                {
                    cmd.CommandText = "ConsultarUsuario";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id_Usuario", idUsario);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idUsuario = reader.GetInt32(0);
                            int idCliente = reader.GetInt32(1);
                            string usuarioName = reader.GetString(2);
                            string contrasenia = reader.GetString(3);
                            DateTime fechaAlta = reader.GetDateTime(4);
                            string nombre = reader.GetString(5);
                            string apellido = reader.GetString(6);
                            int edad = reader.GetInt32(7);
                            DateTime fechaNacimiento = reader.GetDateTime(8);
                            string sexo = reader.GetString(9);
                            string direccion = reader.GetString(10);
                            string correo = reader.GetString(11);
                            DateTime fechaUltimoAcceso = reader.GetDateTime(12);
                            Cliente cliente = new Cliente(idCliente, nombre, apellido, edad, Convert.ToString(fechaNacimiento), sexo, direccion, correo);
                            usuarioCompleto = new Usuario(idUsuario, cliente, usuarioName, contrasenia, Convert.ToString(fechaAlta));
                        }
                    }
                }
            }
            return usuarioCompleto;
        }

        public static string obtenerUltimoAcceso(int idUsario)
        {
            string fechaUltimoAcceso = null;
            using (SqlConnection connection = new SqlConnection(RUTA_DB))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("", connection))
                {
                    cmd.CommandText = "EditarUsuario";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id_Usuario", idUsario);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            fechaUltimoAcceso = reader.GetString(0);
                        }
                    }
                }
            }
            return fechaUltimoAcceso;
        }


    }
}
