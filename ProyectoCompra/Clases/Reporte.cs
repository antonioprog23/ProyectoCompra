using Microsoft.Reporting.WinForms;
using System.IO;

namespace ProyectoCompra.Clases
{
    public class Reporte
    {
        //CONSTANTES
        private const string RUTA_DB = "Data Source=ANTONIO\\SQLEXPRESS;Initial Catalog=EasyShop;Integrated Security=True;";
        private const string RUTA_REPORTE = "../../Reportes/InformeFactura.rdlc";
        public const string RUTA_XSD = "../../Reportes/DSFactura.xsd";

        public static void obtenerReporte(int idUsuario, int idPedido)
        {
            LocalReport localReport = new LocalReport();
            localReport.ReportPath = RUTA_REPORTE;

            ReportParameter[] parameters = new ReportParameter[2];
            parameters[0] = new ReportParameter("Id_Usuario", idUsuario.ToString());
            parameters[1] = new ReportParameter("Id_Pedido", idPedido.ToString());

            localReport.SetParameters(parameters);

            byte[] pdfBytes = localReport.Render("PDF");

            // Guarda el archivo PDF en disco
            string path = @"Descargas/Factura.pdf"; // Ruta donde deseas guardar el PDF
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                fs.Write(pdfBytes, 0, pdfBytes.Length);
            }
        }

    }
}
