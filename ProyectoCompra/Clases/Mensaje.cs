﻿using ProyectoCompra.Base_datos;
using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using System.Net.Mime;

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
                        //mensaje.Body = $"Su nueva contraseña es: {contraseniaNueva}. Se le recomienda cambiarla.";
                        string html = prepararMensaje($"Su nueva contraseña es: {contraseniaNueva}. Se le recomienda cambiarla.");
                        AlternateView htmlView = AlternateView.CreateAlternateViewFromString(html, Encoding.UTF8, MediaTypeNames.Text.Html);
                        mensaje.AlternateViews.Add(htmlView);
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
                    MessageBox.Show("El correo electrónico proporcionado no tiene un formato correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correoValido = false;
                    contraseniaNueva = "-1";
                }
                catch (FormatException)
                {
                    MessageBox.Show("El correo electrónico proporcionado no tiene un formato correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    //mensaje.Body = $"Tu código de verificación es: {codigoVerificacion}";
                    string html = prepararMensaje($"Tu código de verificación es: {codigoVerificacion}");
                    AlternateView htmlView = AlternateView.CreateAlternateViewFromString(html, Encoding.UTF8, MediaTypeNames.Text.Html);
                    mensaje.AlternateViews.Add(htmlView);
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
                    MessageBox.Show("El correo electrónico proporcionado no tiene un formato correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correoValido = false;
                    codigoVerificacion = "-1";
                }
                catch (FormatException)
                {
                    MessageBox.Show("El correo electrónico proporcionado no tiene un formato correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    correoValido = false;
                    codigoVerificacion = "-1";
                }
            }
            return codigoVerificacion;
        }

        //MÉTODOS PRIVADOS
        private static string obtenerCodigoVerificacion()
        {
            string cadena = "";
            int indiceLetras = -1;
            string letrasValidas = "ABCDEFGHJKMNOPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz";
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

        private static string prepararMensaje(string contenido)
        {
            string mensaje = "<!DOCTYPE html> " +
                             "<html lang=\"es\"> " +
                                    "<head>" +
                                        "<meta charset=\"UTF-8\">" +
                                        "<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">" +
                                        "<title>EasyShop</title>" +
                                        "<style> body { font-family: Arial, sans-serif; margin: 0; padding: 0; } header h1 { background-color: #333; color: #ffffff; padding: 20px; text-align: center; } nav ul { list-style: none; padding: 0; margin: 0; } nav ul li { display: inline; margin-right: 10px; } nav ul li a { color: #fff; text-decoration: none; } main { padding: 40px; } section { margin-bottom: 20px; } h1, h2 { color: #333; } footer { background-color: #333; color: #fff; padding: 20px; text-align: center; } </style>" +
                                    "</head>" +
                                    "<body>" +
                                        "<header>" +
                                            "<h1>Bienvenido a EasyShop</h1>" +
                                        "</header>" +
                                        "<main>" +
                                            $"<p>{contenido}<p>" +
                                        "</main>" +
                                        "<footer>" +
                                            "<p>&copy; Vendido y enviado por EasyShop</p>" +
                                        "</footer>" +
                                    "</body>" +
                               "</html>";
            return mensaje;
        }
    }
}
