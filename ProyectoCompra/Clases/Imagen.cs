using ProyectoCompra.Properties;
using System.Drawing;

namespace ProyectoCompra.Clases
{
    internal class Imagen
    {
        public static Image cargarImagen(int contador, int subCategoria)
        {
            Image image = null;
            switch (subCategoria)
            {
                case 1:
                    image = AlimentacionS1.ResourceManager.GetObject(string.Format("_1_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_1_{contador}".ToString();
                    }
                    break;
                case 2:
                    image = AlimentacionS2.ResourceManager.GetObject(string.Format("_2_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_2_{contador}".ToString();
                    }
                    break;
                case 3:
                    image = AlimentacionS1.ResourceManager.GetObject(string.Format("_3_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_3_{contador}".ToString();
                    }
                    break;
                case 4:
                    image = AlimentacionS1.ResourceManager.GetObject(string.Format("_4_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_4_{contador}".ToString();
                    }
                    break;
                case 5:
                    image = AlimentacionS1.ResourceManager.GetObject(string.Format("_5_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_5_{contador}".ToString();
                    }
                    break;
                case 6:
                    image = AlimentacionS1.ResourceManager.GetObject(string.Format("_6_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_6_{contador}".ToString();
                    }
                    break;
            }

            return image;
        }

        //AL GUARDAR UN PRODUCTO EN EL CARRITO, SE GUARDA LA REFERENCIA A LA IMAGEN
        public static Image obtenerImagenDB(string rutaImagen)
        {
            string[] data = rutaImagen.Split('_');
            string categoria = data[1];
            Image imagen = null;
            switch (categoria)
            {
                case "1":
                    imagen = AlimentacionS1.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
            }
            return imagen;
        }

    }
}
