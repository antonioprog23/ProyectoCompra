﻿using ProyectoCompra.Clases;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProyectoCompra.Base_datos
{
    internal class BDUsuario
    {
        //CONSTANTES
        private const string RUTA_DB = "Data Source=ANTONIO\\SQLEXPRESS;Initial Catalog=EasyShop;Integrated Security=True;";
        public static bool insertarDatos(Cliente cliente, Usuario usuario)
        {
            bool insertado = true;
            using (SqlConnection connection = new SqlConnection(RUTA_DB))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    using (SqlCommand cmd = new SqlCommand("InsertarDatos", connection, transaction))
                    {
                        try
                        {
                            //cmd.CommandText = "InsertarDatos";
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

        public static Usuario obtenerDatos(params string[] datos)
        {
            Usuario usuarioCompleto = null;
            Cliente cliente = null;
            using (SqlConnection connection = new SqlConnection(RUTA_DB))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("ConsultarUsuario", connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Usuario_name", datos[0]);
                    cmd.Parameters.AddWithValue("@Contrasenia", datos[1]);
                    cmd.Parameters.AddWithValue("@Id_Usuario", datos[2]);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idUsuario = reader.GetInt32(0);
                            int idCliente = reader.GetInt32(1);
                            string usuarioName = reader.GetString(2);
                            string contrasenia = reader.GetString(3);
                            DateTime fechaAlta = reader.GetDateTime(4);
                            DateTime fechaUltimaModificacion = reader.GetDateTime(5);
                            string nombre = reader.GetString(6);
                            string apellido = reader.GetString(7);
                            int edad = reader.GetInt32(8);
                            DateTime fechaNacimiento = reader.GetDateTime(9);
                            string sexo = reader.GetString(10);
                            string direccion = reader.GetString(11);
                            string correo = reader.GetString(12);
                            cliente = new Cliente(idCliente, nombre, apellido, edad, Convert.ToString(fechaNacimiento), sexo, direccion, correo);
                            usuarioCompleto = new Usuario(idUsuario, cliente, usuarioName, contrasenia, Convert.ToString(fechaAlta), Convert.ToString(fechaUltimaModificacion));
                        }
                    }
                }
            }
            return usuarioCompleto;
        }

        public static int consultarUsuarioName(string usuarioName)
        {
            //DEVOLVERA 1 EN CASO DE QUE EXISTA YA EN LA BASE DE DATOS (1 = TRUE)
            int idUsuario = 0;
            using (SqlConnection connection = new SqlConnection(RUTA_DB))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("ConsultarUsuarioName", connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Usuario_name", usuarioName);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            idUsuario = reader.GetInt32(0);
                        }
                    }

                }
            }
            return idUsuario;
        }

        public static int consultarUsuarioCorreoElectronico(string correoElectronico)
        {
            //DEVOLVERA 1 EN CASO DE QUE EXISTA YA EN LA BASE DE DATOS (1 = TRUE)
            int idUsuario = 0;
            using (SqlConnection connection = new SqlConnection(RUTA_DB))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("ConsultarUsuarioCorreoElectronico", connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Correo_Electronico", correoElectronico);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            idUsuario = reader.GetInt32(0);
                        }
                    }

                }
            }
            return idUsuario;
        }

        public static bool actualiarDatos(params string[] datos)
        {
            bool actualizado = false;
            using (SqlConnection connection = new SqlConnection(RUTA_DB))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    using (SqlCommand cmd = new SqlCommand("ActualizarDatos", connection, transaction))
                    {
                        try
                        {
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Usuario_name", datos[0]);
                            cmd.Parameters.AddWithValue("@Direccion", datos[1]);
                            cmd.Parameters.AddWithValue("@Correo_Electronico", datos[2]);
                            cmd.Parameters.AddWithValue("@Contrasenia", datos[3]);
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

        public static bool insertarDatosLogin(string userName)
        {
            bool insertado = true;
            using (SqlConnection connection = new SqlConnection(RUTA_DB))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    using (SqlCommand cmd = new SqlCommand("InsertarDatosLogin", connection, transaction))
                    {
                        try
                        {
                            //cmd.CommandText = "InsertarDatos";
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            //USUARIO
                            cmd.Parameters.AddWithValue("@Usuario_name", userName);
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

        public static bool darBajaUsuarioPorUsuario(string userName, string contrasenia)
        {
            bool eliminado = true;
            using (SqlConnection connection = new SqlConnection(RUTA_DB))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    using (SqlCommand cmd = new SqlCommand("DarBajaUsuarioPorUsuario", connection, transaction))
                    {
                        try
                        {
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Usuario_name", userName);
                            cmd.Parameters.AddWithValue("@Contrasenia", contrasenia);
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

        public static bool darBajaUsuarioPorCorreoElectronico(string correoElectronico)
        {
            bool eliminado = true;
            using (SqlConnection connection = new SqlConnection(RUTA_DB))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    using (SqlCommand cmd = new SqlCommand("DarBajaUsuarioPorCorreoElectronico", connection, transaction))
                    {
                        try
                        {
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Correo_Electronico", correoElectronico);
                            cmd.ExecuteNonQuery();
                            transaction.Commit();
                            eliminado = true;
                        }
                        catch (SqlException E)
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
