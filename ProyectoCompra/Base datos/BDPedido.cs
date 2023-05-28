using ProyectoCompra.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

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

        public static List<Factura> consultarFacturas(int idUsuario, DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Factura> facturas = new List<Factura>();
            List<LineaPedido> lineasPedido = new List<LineaPedido>();
            using (SqlConnection connection = new SqlConnection(RUTA_DB))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("ConsultarPedido", connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id_Usuario", idUsuario);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Direccion direccion = new Direccion(reader["Nombre"].ToString(), reader["Direccion"].ToString(), reader["Pais"].ToString(), reader["Provincia"].ToString(), reader["Ciudad"].ToString(), reader["Codigo_Postal"].ToString(), reader["Telefono"].ToString());
                            Cliente cliente = new Cliente(reader["Nombre"].ToString(), reader["Apellido"].ToString());
                            Usuario usuario = new Usuario(cliente);
                            Imagen imagen = new Imagen(reader["Codigo_Imagen"].ToString());
                            Producto producto = new Producto(Convert.ToInt32(reader["Id_Producto"]), Convert.ToInt32(reader["Id_Subcategoria"]), reader["Nombre_Producto"].ToString(), reader["Descripcion"].ToString(), Convert.ToDecimal(reader["Precio"]), reader["Fabricante"].ToString(), imagen);
                            LineaPedido linea = new LineaPedido(Convert.ToInt32(reader["Id_Linea_Pedido"]), Convert.ToInt32(reader["Id_Pedido"]), producto, Convert.ToInt32(reader["Cantidad"]), Convert.ToDecimal(reader["Subtotal"]));
                            lineasPedido.Add(linea);
                            Pedido pedido = new Pedido(Convert.ToInt32(reader["Id_Pedido"]), usuario, lineasPedido, direccion, Convert.ToInt32(reader["Id_Estado_Pedido"]), Convert.ToDateTime(reader["Fecha"]));

                            //SE COMPROBRA SI EL IDFACTURA EXISTE YA EN LA LISTA O NO
                            //SI NO EXISTE EL IDFACTURA EN LA LISTA, SE CREA NUEVA FACTURA Y SE AÑADE A LA LISTA
                            int idFactura = Convert.ToInt32(reader["Id_Factura"]);
                            Factura factura = facturas.FirstOrDefault(f => f.idFactura == idFactura);
                            if (factura == null)
                            {
                                factura = new Factura(Convert.ToInt32(reader["Id_Factura"]), pedido, Convert.ToInt32(reader["Id_Estado_Factura"]), Convert.ToDateTime(reader["Fecha_Factura"]));
                                facturas.Add(factura);
                            }
                        }
                        return facturas;
                    }
                }
            }
        }
    }
}
