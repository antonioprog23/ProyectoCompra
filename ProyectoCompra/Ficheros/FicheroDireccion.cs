using ProyectoCompra.Clases;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProyectoCompra.Ficheros
{
    internal class FicheroDireccion
    {
        //CONSTANTE
        private const string FICHERO = "..\\..\\Ficheros\\direccion.text";

        public static void escribirFichero(Direccion direccion)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(FICHERO, true))
                {
                    sw.WriteLine(direccion.toStringWithSeparator());
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

        public static List<Direccion> leerFichero()
        {
            List<Direccion> direcciones = new List<Direccion>();
            try
            {
                if (File.Exists(FICHERO))
                {
                    using (StreamReader sr = new StreamReader(FICHERO))
                    {
                        string linea = sr.ReadLine();
                        while (linea != null)
                        {
                            Direccion direccion = new Direccion(linea);
                            direcciones.Add(direccion);
                            linea = sr.ReadLine();
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

            return direcciones;
        }

        public static bool editarFichero(int idDireccion, Direccion direccionNuevosDatos)
        {
            bool editado = false;
            List<Direccion> direcciones = leerFichero();
            if (direcciones.Count > 0 && direcciones != null)
            {
                Direccion direccionEditar = direcciones.Find(d => d.idDireccion == idDireccion);
                if (direccionEditar != null)
                {
                    int index = direcciones.IndexOf(direccionEditar);
                    direcciones[index].nombre = direccionNuevosDatos.nombre;
                    direcciones[index].direccion = direccionNuevosDatos.direccion;
                    direcciones[index].pais = direccionNuevosDatos.pais;
                    direcciones[index].provincia = direccionNuevosDatos.provincia;
                    direcciones[index].ciudad = direccionNuevosDatos.ciudad;
                    direcciones[index].codigoPostal = direccionNuevosDatos.codigoPostal;
                    direcciones[index].telefono = direccionNuevosDatos.telefono;
                }
                borrarFicheroAux();
                foreach (Direccion direccion in direcciones)
                {
                    escribirFichero(direccion);
                }
            }
            return editado;
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

        public static int obtenerIdDireccionMax()
        {
            int idDireccion = 0;
            List<Direccion> direcciones = leerFichero();
            if (direcciones.Count > 0 && direcciones != null)
            {
                idDireccion = direcciones.Max(d => d.idDireccion);
            }
            return idDireccion + 1;
        }
    }
}
