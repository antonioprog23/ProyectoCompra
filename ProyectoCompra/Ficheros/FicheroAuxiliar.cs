using ProyectoCompra.Clases;
using System.IO;

namespace ProyectoCompra.Ficheros
{
    internal class FicheroAuxiliar
    {
        //CONSTANTE
        private const string FICHERO = "..\\..\\Ficheros\\datosProvisionales.text";

        public static void escribirFichero(Usuario usuario)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(FICHERO))
                {
                    sw.WriteLine(usuario.toStringConSeparador());
                    File.SetAttributes(FICHERO, FileAttributes.Encrypted);
                    //File.SetAttributes(FICHERO, FileAttributes.Hidden);
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

        public static Usuario leerFichero()
        {
            Usuario usuario = null;
            try
            {
                using (StreamReader sr = new StreamReader(FICHERO))
                {
                    string linea = sr.ReadLine();
                    if (linea != null)
                    {
                        usuario = new Usuario(linea);
                    }
                }
            }
            catch (FileNotFoundException e)
            {

            }
            catch (DirectoryNotFoundException d)
            {

            }
            catch (IOException e)
            {

            }

            return usuario;
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
