using Microsoft.Reporting.WebForms;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoCompra.Clases
{
    public class Reporte
    {
        private const string RUTA_REPORTE = @"C:\Users\anton\source\repos\ProyectoCompra\ProyectoCompra\Reportes\InformeFactura.rdlc";
        public const string RUTA_XSD = @"C:\Users\anton\source\repos\ProyectoCompra\ProyectoCompra\Reportes\DSFactura.xsd";

        public static byte[] obtenerReporte(int idUsuario)
        {
            // Crear el informe y exportarlo a un arreglo de bytes en formato PDF
            using (ReportViewer reportViewer = new ReportViewer())
            {
                reportViewer.ProcessingMode = ProcessingMode.Local;
                reportViewer.LocalReport.ReportPath = RUTA_REPORTE;
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DSFactura", obtenerDataSet(idUsuario)));

                // Renderizar el informe como PDF
                byte[] reportBytes = reportViewer.LocalReport.Render("PDF");
                return reportBytes;
            }
        }

        public static DataSet obtenerDataSet(int idUsuario)
        {
            // Crear la conexión a la base de datos
            using (SqlConnection conn = new SqlConnection("cadena de conexión"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("ConsultarFactura", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);
                        return dataSet;
                    }
                }
            }
        }
    }
}
