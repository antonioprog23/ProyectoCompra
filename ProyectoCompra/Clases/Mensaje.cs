
using Microsoft.Reporting.WebForms;
using ProyectoCompra.Base_datos;
using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace ProyectoCompra.Clases
{
    internal class Mensaje
    {
        private const string REMITENTE = "easyshopatencioncliente@gmail.com";
        //private const string CONTRASENIA = "EasyshopAtencionCliente2023";
        private const string CONTRASENIA_DE_APLICACION = "fgrdfuahkbqjbldf";

        public static string enviarMensajeContraseniaUnDestinatario(string destinatario, string usuarioName)
        {
            string contraseniaNueva = obtenerCodigoVerificacion();
            bool correoValido = true;
            if (!contraseniaNueva.Equals(""))
            {
                try
                {
                    if (BDUsuario.actualiarDatos(usuarioName, contraseniaNueva, ""))
                    {
                        MailMessage mensaje = new MailMessage(REMITENTE, destinatario);
                        mensaje.Subject = "Contraseña nueva.";
                        mensaje.Body = $"Su nueva contraseña es: {contraseniaNueva}. Se le recomienda cambiarla.";
                        if (correoValido)
                        {
                            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                            smtpClient.EnableSsl = true;
                            smtpClient.UseDefaultCredentials = false;
                            smtpClient.Credentials = new NetworkCredential(REMITENTE, CONTRASENIA_DE_APLICACION);
                            smtpClient.Send(mensaje);
                            MessageBox.Show("Se ha enviado un correo con su nueva contraseña. Por favor, tenga en cuenta la advertencia.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("El correo electrónico proporcionado no tiene un formato correcto.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correoValido = false;
                    contraseniaNueva = "-1";
                }
                catch (FormatException)
                {
                    MessageBox.Show("El correo electrónico proporcionado no tiene un formato correcto.", "Correo electrónico error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    correoValido = false;
                    contraseniaNueva = "-1";
                }
            }
            return contraseniaNueva;
        }

        public static string enviarMensajeCodigoVerificacionUnDestinatario(string destinatario)
        {
            string codigoVerificacion = obtenerCodigoVerificacion();
            bool correoValido = true;
            if (!codigoVerificacion.Equals(""))
            {
                try
                {
                    MailMessage mensaje = new MailMessage(REMITENTE, destinatario);
                    mensaje.Subject = "´Código de verificación.";
                    mensaje.Body = $"Tu código de verificación es: {codigoVerificacion}";
                    if (correoValido)
                    {
                        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                        smtpClient.EnableSsl = true;
                        smtpClient.UseDefaultCredentials = false;
                        smtpClient.Credentials = new NetworkCredential(REMITENTE, CONTRASENIA_DE_APLICACION);
                        smtpClient.Send(mensaje);
                        MessageBox.Show("Se ha enviado un código de verificación a su correo. Por favor, introduzcalo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("El correo electrónico proporcionado no tiene un formato correcto.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correoValido = false;
                    codigoVerificacion = "-1";
                }
                catch (FormatException)
                {
                    MessageBox.Show("El correo electrónico proporcionado no tiene un formato correcto.", "Correo electrónico error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    correoValido = false;
                    codigoVerificacion = "-1";
                }
            }
            return codigoVerificacion;
        }

        public static void enviareReporte(string destinatario)
        {
            bool correoValido = true;
            try
            {
                MailMessage mensaje = new MailMessage(REMITENTE, destinatario);
                mensaje.Subject = "Código de verificación.";
                mensaje.Body = $"Tu código de verificación es:";

                //ADJUNTAR ARCHIVO
                Attachment attachment = new Attachment(new MemoryStream(Reporte.obtenerReporte(ConfigSesion.obtenerReferenciaIdUsuario())), "report.pdf", "application/pdf");
                mensaje.Attachments.Add(attachment);

                if (correoValido)
                {
                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                    smtpClient.EnableSsl = true;
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(REMITENTE, CONTRASENIA_DE_APLICACION);
                    smtpClient.Send(mensaje);
                    MessageBox.Show("Se ha enviado un código de verificación a su correo. Por favor, introduzcalo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("El correo electrónico proporcionado no tiene un formato correcto.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                correoValido = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("El correo electrónico proporcionado no tiene un formato correcto.", "Correo electrónico error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                correoValido = false;
            }
        }

        //MÉTODOS PRIVADOS
        private static string obtenerCodigoVerificacion()
        {
            string cadena = "";
            int indiceLetras = -1;
            string letrasValidas = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    cadena += random.Next(0, 10);
                }
                else
                {
                    indiceLetras = random.Next(letrasValidas.Length);
                    cadena += letrasValidas[indiceLetras];
                }
            }
            return cadena;
        }
    }
}
