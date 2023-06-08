using System;
using System.Configuration;

namespace ProyectoCompra.Clases
{
    public class ConfigSesion
    {
        public static bool guardarReferenciaIdUsuario(int id)
        {
            bool guardado = false;
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                KeyValueConfigurationElement element = config.AppSettings.Settings["idUsuario"];
                config.AppSettings.Settings.Add("idUsuario", id.ToString());
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                guardado = true;
            }
            catch (ConfigurationErrorsException ex)
            {
                guardado = false;
                throw ex;
            }
            return guardado;
        }

        public static bool borrarReferenciaIdUsuario()
        {
            bool borrado = false;
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings.Remove("idUsuario");
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                borrado = true;
            }
            catch (ConfigurationErrorsException ex)
            {
                borrado = false;
                throw ex;
            }
            return borrado;
        }

        public static int obtenerReferenciaIdUsuario()
        {
            int idUsuario = 0;
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                KeyValueConfigurationElement element = config.AppSettings.Settings["idUsuario"];
                if (element != null)
                {
                    idUsuario = Convert.ToInt32(element.Value);
                }
            }
            catch (ConfigurationErrorsException ex)
            {
                throw ex;
            }
            return idUsuario;
        }
    }
}
