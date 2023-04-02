using ProyectoCompra.Clases;
using System.Collections.Generic;
using System.IO;

namespace ProyectoCompra.Ficheros
{
    internal class FicheroCarrito
    {
        //CONSTANTE
        private const string FICHERO = "..\\..\\Ficheros\\carritoProvisional.text";

        public static void escribirFichero(Carrito carrito)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(FICHERO, true))
                {
                    sw.WriteLine(carrito.toStringConSeparador());
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

        public static List<Carrito> leerFichero()
        {
            List<Carrito> productos = new List<Carrito>();
            try
            {
                if (File.Exists(FICHERO))
                {
                    using (StreamReader sr = new StreamReader(FICHERO))
                    {
                        string linea = sr.ReadLine();
                        while (linea != null)
                        {
                            Carrito carrito = new Carrito(linea);
                            productos.Add(carrito);
                            linea = sr.ReadLine();
                        }
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

            return productos;
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
