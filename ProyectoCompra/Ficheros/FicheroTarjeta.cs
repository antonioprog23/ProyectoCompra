using ProyectoCompra.Clases;
using System.IO;

namespace ProyectoCompra.Ficheros
{
    internal class FicheroTarjeta
    {
        //CONSTANTE
        private const string FICHERO = "..\\..\\Ficheros\\FicheroTarjeta.text";

        public static void escribirFichero(TarjetaCredit tarjetaCredit)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(FICHERO))
                {
                    sw.WriteLine(tarjetaCredit.ToStringWithSeparator());
                    File.SetAttributes(FICHERO, FileAttributes.Encrypted);
                    File.SetAttributes(FICHERO, FileAttributes.Normal);
                }
            }
            catch (DirectoryNotFoundException d)
            {
                throw d;
            }
            catch (IOException e)
            {
                throw e;
            }
        }

        public static TarjetaCredit leerFichero()
        {
            TarjetaCredit tarjetaCredit = null;
            try
            {
                if (File.Exists(FICHERO))
                {
                    using (StreamReader sr = new StreamReader(FICHERO))
                    {
                        string linea = sr.ReadLine();
                        if (linea != null)
                        {
                            tarjetaCredit = new TarjetaCredit(linea);
                        }
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                throw e;
            }
            catch (DirectoryNotFoundException d)
            {
                throw d;
            }
            catch (IOException e)
            {
                throw e;
            }

            return tarjetaCredit;
        }

        public static bool borrarFicheroAux()
        {
            bool eliminado = false;
            if (File.Exists(FICHERO))
            {
                try
                {
                    File.Delete(FICHERO);
                    eliminado = true;
                }
                catch (DirectoryNotFoundException)
                {

                }
                catch (IOException)
                {

                }
            }
            return eliminado;
        }
    }
}
