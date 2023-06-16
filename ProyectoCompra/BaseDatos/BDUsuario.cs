using ProyectoCompra.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace ProyectoCompra.Base_datos
{
    public class BDUsuario
    {
        /// <summary>
        /// Da de alta en el sistema al nuevo usuario.
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="usuario"></param>
        /// <returns>True, insertado o false, no inertado.</returns>
        public static bool insertarDatos(Cliente cliente, Usuario usuario)
        {
            bool insertado = true;
            using (SqlConnection connection = new SqlConnection(Servidor.RUTA_DB))
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
                            cmd.Parameters.AddWithValue("@CorreoElectronico", cliente.correo);
                            //USUARIO
                            cmd.Parameters.AddWithValue("@Usuario_name", usuario.username);
                            cmd.Parameters.AddWithValue("@Contrasenia", usuario.password);
                            cmd.Parameters.AddWithValue("@Invitado", usuario.invitado);
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

        /// <summary>
        /// Inserta los datos del usuario invitado una vez realizada la compra.
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="usuario"></param>
        /// <param name="direccion"></param>
        /// <param name="provisional"></param>
        /// <param name="metodoPago"></param>
        /// <returns>True, insertado o false, no inertado.</returns>
        public static bool insertarDatosInvitado(Cliente cliente, Usuario usuario, Direccion direccion, List<CarritoProvisional> provisional, int metodoPago)
        {
            bool insertado = true;
            using (SqlConnection connection = new SqlConnection(Servidor.RUTA_DB))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    using (SqlCommand cmd = new SqlCommand("InsertarDatosInvitado", connection, transaction))
                    {
                        try
                        {
                            //cmd.CommandText = "InsertarDatos";
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            //CLIENTE
                            cmd.Parameters.AddWithValue("@Nombre", cliente.nombre);
                            //USUARIO
                            cmd.Parameters.AddWithValue("@Invitado", usuario.invitado);
                            cmd.Parameters.AddWithValue("@Id_Usuario", usuario.idUsuario);
                            //DIRECCION
                            cmd.Parameters.AddWithValue("@Nombre_Direccion", direccion.nombre);
                            cmd.Parameters.AddWithValue("@Direccion", direccion.direccion);
                            cmd.Parameters.AddWithValue("@Pais", direccion.pais);
                            cmd.Parameters.AddWithValue("@Provincia", direccion.provincia);
                            cmd.Parameters.AddWithValue("@Ciudad", direccion.ciudad);
                            cmd.Parameters.AddWithValue("@Codigo_Postal", direccion.codigoPostal);
                            cmd.Parameters.AddWithValue("@Telefono", direccion.telefono);
                            //CARRITO PROVISIONAL
                            cmd.Parameters.AddWithValue("@Productos", obtenerDT(provisional));
                            //METODO DE PAGO
                            cmd.Parameters.AddWithValue("@Id_Metodo_Pago", metodoPago);
                            cmd.ExecuteNonQuery();
                            transaction.Commit();
                            insertado = true;
                        }
                        catch (SqlException e)
                        {
                            insertado = false;
                            transaction.Rollback();
                            throw e;
                        }
                    }
                }
            }
            return insertado;
        }

        //Se obtiene la tabla que se pasara al procedimiento almacenado InsertarDatosInvitado
        private static DataTable obtenerDT(List<CarritoProvisional> carritoProvisional)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id_Producto", typeof(int));
            dt.Columns.Add("Cantidad", typeof(string));
            foreach (CarritoProvisional productos in carritoProvisional)
            {
                DataRow dr = dt.NewRow();
                dr["Id_Producto"] = productos.idProducto;
                dr["Cantidad"] = productos.cantidad;
                dt.Rows.Add(dr);
            }
            return dt;
        }

        /// <summary>
        /// Se obtiene los datos del usuario mediante usuario y contraseña o con el IdUsuario.
        /// Usos:
        /// Este se emplea para el inicio de sesión.
        /// Recuperar datos para mostrar en el perfil.
        /// </summary>
        /// <param name="datos"></param>
        /// <returns>Usuario con los datos.</returns>
        public static Usuario obtenerDatos(params string[] datos)
        {
            Usuario usuarioCompleto = null;
            Cliente cliente = null;
            using (SqlConnection connection = new SqlConnection(Servidor.RUTA_DB))
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
                            string correo = reader.GetString(11);
                            cliente = new Cliente(idCliente, nombre, apellido, edad, Convert.ToString(fechaNacimiento), sexo, correo);
                            usuarioCompleto = new Usuario(idUsuario, cliente, usuarioName, contrasenia, Convert.ToString(fechaAlta), Convert.ToString(fechaUltimaModificacion));
                        }
                    }
                }
            }
            return usuarioCompleto;
        }

        /// <summary>
        /// Devuelve el IdUsuario que tiene asociado el usuarioname.
        /// Si el usuarioname no pertenece a un usuario, devuelve 0.
        /// </summary>
        /// <param name="usuarioName"></param>
        /// <returns>IdUsuario o 0.</returns>
        public static int consultarUsuarioName(string usuarioName)
        {
            //DEVOLVERA 1 EN CASO DE QUE EXISTA YA EN LA BASE DE DATOS (1 = TRUE)
            int idUsuario = 0;
            using (SqlConnection connection = new SqlConnection(Servidor.RUTA_DB))
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

        /// <summary>
        /// Devuelve el IdUsuario que tiene asociado el correo electrónico.
        /// Si el correo electrónico no pertenece a un usuario, devuelve 0.
        /// </summary>
        /// <param name="correoElectronico"></param>
        /// <returns>IdUsuario o 0.</returns>
        public static int consultarUsuarioCorreoElectronico(string correoElectronico)
        {
            //DEVOLVERA 1 EN CASO DE QUE EXISTA YA EN LA BASE DE DATOS (1 = TRUE)
            int idUsuario = 0;
            using (SqlConnection connection = new SqlConnection(Servidor.RUTA_DB))
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

        /// <summary>
        /// Se consulta el IdUsuario asociado al usuario invitado.
        /// </summary>
        /// <returns>Id del usuario invitado.</returns>
        public static int consultarIdUsuarioInvitado()
        {
            int idUsuario = 0;
            using (SqlConnection connection = new SqlConnection(Servidor.RUTA_DB))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("ConsultarIdUsuarioInvitado", connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
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

        /// <summary>
        /// Se actualizan los datos del usuario usando el usuarioname. 
        /// Solamente se pueden actualizar la contraseña o el correo electrónico.
        /// </summary>
        /// <param name="datos"></param>
        /// <returns>True, actualizado o false, no actualizado.</returns>
        public static bool actualiarDatos(params string[] datos)
        {
            bool actualizado = false;
            using (SqlConnection connection = new SqlConnection(Servidor.RUTA_DB))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    using (SqlCommand cmd = new SqlCommand("ActualizarDatos", connection, transaction))
                    {
                        try
                        {
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Usuario_Name", datos[0]);
                            cmd.Parameters.AddWithValue("@Contrasenia", datos[1]);
                            cmd.Parameters.AddWithValue("@Correo_Electronico", datos[2]);
                            cmd.ExecuteNonQuery();
                            transaction.Commit();
                            actualizado = true;
                        }
                        catch (SqlException e)
                        {
                            actualizado = false;
                            transaction.Rollback();
                            throw e;
                        }
                    }
                }
            }
            return actualizado;
        }

        /// <summary>
        /// Se da de baja al usuario empleado usuarioname y contraseña.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="contrasenia"></param>
        /// <returns>True, eliminado o false, no eliminado.</returns>
        public static bool darBajaUsuarioPorUsuario(string userName, string contrasenia)
        {
            bool eliminado = true;
            using (SqlConnection connection = new SqlConnection(Servidor.RUTA_DB))
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
                        catch (SqlException e)
                        {
                            eliminado = false;
                            transaction.Rollback();
                            throw e;
                        }
                    }
                }
            }
            return eliminado;
        }

        /// <summary>
        /// Se da de baja al usuario empleado el correo electrónico.
        /// </summary>
        /// <param name="correoElectronico"></param>
        /// <returns>True, eliminado o false, no eliminado.</returns>
        public static bool darBajaUsuarioPorCorreoElectronico(string correoElectronico)
        {
            bool eliminado = true;
            using (SqlConnection connection = new SqlConnection(Servidor.RUTA_DB))
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
                        catch (SqlException e)
                        {
                            eliminado = false;
                            transaction.Rollback();
                            throw e;
                        }
                    }
                }
            }
            return eliminado;
        }

    }
}
