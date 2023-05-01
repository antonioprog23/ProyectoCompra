
using System;
using System.Net;
using System.Net.Mail;

namespace ProyectoCompra.Clases
{
    internal class Mensaje
    {
        private const string REMITENTE = "easyshopatencioncliente@gmail.com";
        //private const string CONTRASENIA = "EasyshopAtencionCliente2023";
        private const string CONTRASENIA_DE_APLICACION = "fgrdfuahkbqjbldf";

        public static string enviarMensajeUnDestinatario(string destinatario)
        {
            string codigoVerificacion = obtenerCodigoVerificacion();
            if (!codigoVerificacion.Equals(""))
            {
                MailMessage mensaje = new MailMessage(REMITENTE, destinatario);
                mensaje.Subject = "´Código de verificación.";
                mensaje.Body = $"Tu código de verificación es: {obtenerCodigoVerificacion()}";
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(REMITENTE, CONTRASENIA_DE_APLICACION);
                smtpClient.Send(mensaje);
            }
            return codigoVerificacion;
        }

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
