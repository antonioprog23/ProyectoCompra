using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.Reporting.WebForms;
using ProyectoCompra.Reportes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web;

namespace ProyectoCompra.Clases
{
    public class Reporte
    {
        //CONSTANTES
        private const string RUTA_DB = "Data Source=ANTONIO\\SQLEXPRESS;Initial Catalog=EasyShop;Integrated Security=True;";
        private const string RUTA_REPORTE = "~/Reportes/InformeFactura.rdlc";
        public const string RUTA_XSD = "~/Reportes/DSFactura.xsd";

        public static void obtenerReporte(int idUsuario, int idPedido)
        {
            
            using (SqlConnection connection = new SqlConnection(RUTA_DB))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("ConsultarFactura", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id_Usuario", idUsuario);
                    command.Parameters.AddWithValue("@Id_Pedido", idPedido);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        ReportViewer reportViewer = new ReportViewer();
                        reportViewer.ProcessingMode = ProcessingMode.Local;
                        reportViewer.LocalReport.ReportPath = HttpContext.Current.Server.MapPath(RUTA_REPORTE);

                        ReportDataSource reportDataSource = new ReportDataSource(HttpContext.Current.Server.MapPath(RUTA_XSD), dataTable);
                        reportViewer.LocalReport.DataSources.Add(reportDataSource);

                        byte[] pdfBytes = reportViewer.LocalReport.Render("PDF");
                        string filePath = @"C:\\Descargas\\Factura.pdf";
                        File.WriteAllBytes(filePath, pdfBytes);

                    }
                }
            }
        }
    }
}
