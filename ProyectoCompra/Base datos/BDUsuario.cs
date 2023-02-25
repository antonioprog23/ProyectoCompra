using ProyectoCompra.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCompra.Base_datos
{
    internal class BDUsuario
    {
        //CONSTANTES
        private const string RUTA_DB = "Data Source=ANTONIO\\SQLEXPRESS;Initial Catalog=Compras;Integrated Security=True;";
        

        public static int comprobarUsuarioExiste(Usuario usuario)
        {
            int valor = 0;
            using (SqlConnection connection = new SqlConnection(RUTA_DB))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("", connection))
                {
                    cmd.CommandText = "ComprobarUsuario";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Usuario_name", usuario.username);
                    cmd.Parameters.AddWithValue("@Contrasenia", usuario.password);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            valor = reader.GetInt32(0);
                        }
                    }
                }
            }
            return valor;
        }
             
    }
}
