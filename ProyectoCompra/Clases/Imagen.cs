using ProyectoCompra.Properties;
using System.Drawing;

namespace ProyectoCompra.Clases
{
    public class Imagen
    {
        public string imagen { get; set; }

        public Imagen(string imagen)
        {
            this.imagen = imagen;
        }

        public Imagen()
        {

        }

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
                    image = AlimentacionS3.ResourceManager.GetObject(string.Format("_3_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_3_{contador}".ToString();
                    }
                    break;
                case 4:
                    image = AlimentacionS4.ResourceManager.GetObject(string.Format("_4_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_4_{contador}".ToString();
                    }
                    break;
                case 5:
                    image = AlimentacionS5.ResourceManager.GetObject(string.Format("_5_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_5_{contador}".ToString();
                    }
                    break;
                case 6:
                    image = AlimentacionS6.ResourceManager.GetObject(string.Format("_6_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_6_{contador}".ToString();
                    }
                    break;
                case 7:
                    image = AlimentacionS7.ResourceManager.GetObject(string.Format("_7_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_7_{contador}".ToString();
                    }
                    break;
                case 8:
                    image = AlimentacionS8.ResourceManager.GetObject(string.Format("_8_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_8_{contador}".ToString();
                    }
                    break;
                case 9:
                    image = AlimentacionS9.ResourceManager.GetObject(string.Format("_9_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_9_{contador}".ToString();
                    }
                    break;
                case 10:
                    image = AlimentacionS10.ResourceManager.GetObject(string.Format("_10_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_10_{contador}".ToString();
                    }
                    break;
                case 11:
                    image = AlimentacionS11.ResourceManager.GetObject(string.Format("_11_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_11_{contador}".ToString();
                    }
                    break;
                case 12:
                    image = AlimentacionS12.ResourceManager.GetObject(string.Format("_12_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_12_{contador}".ToString();
                    }
                    break;
                case 13:
                    image = AlimentacionS13.ResourceManager.GetObject(string.Format("_13_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_13_{contador}".ToString();
                    }
                    break;
                case 14:
                    image = AlimentacionS14.ResourceManager.GetObject(string.Format("_14_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_14_{contador}".ToString();
                    }
                    break;
                case 15:
                    image = AlimentacionS15.ResourceManager.GetObject(string.Format("_15_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_15_{contador}".ToString();
                    }
                    break;
                case 16:
                    image = AlimentacionS16.ResourceManager.GetObject(string.Format("_16_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_16_{contador}".ToString();
                    }
                    break;
                case 17:
                    image = AlimentacionS17.ResourceManager.GetObject(string.Format("_17_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_17_{contador}".ToString();
                    }
                    break;
                case 18:
                    image = AlimentacionS18.ResourceManager.GetObject(string.Format("_18_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_18_{contador}".ToString();
                    }
                    break;
                case 19:
                    image = AlimentacionS19.ResourceManager.GetObject(string.Format("_19_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_19_{contador}".ToString();
                    }
                    break;
                case 20:
                    image = AlimentacionS20.ResourceManager.GetObject(string.Format("_20_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_20_{contador}".ToString();
                    }
                    break;
                case 21:
                    image = AlimentacionS21.ResourceManager.GetObject(string.Format("_21_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_21_{contador}".ToString();
                    }
                    break;
                case 22:
                    image = AlimentacionS22.ResourceManager.GetObject(string.Format("_22_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_22_{contador}".ToString();
                    }
                    break;
                case 23:
                    image = AlimentacionS23.ResourceManager.GetObject(string.Format("_23_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_23_{contador}".ToString();
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
                case "2":
                    imagen = AlimentacionS2.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "3":
                    imagen = AlimentacionS3.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "4":
                    imagen = AlimentacionS4.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "5":
                    imagen = AlimentacionS5.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "6":
                    imagen = AlimentacionS6.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "7":
                    imagen = AlimentacionS7.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "8":
                    imagen = AlimentacionS8.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "9":
                    imagen = AlimentacionS9.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "10":
                    imagen = AlimentacionS10.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "11":
                    imagen = AlimentacionS11.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "12":
                    imagen = AlimentacionS12.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "13":
                    imagen = AlimentacionS13.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "14":
                    imagen = AlimentacionS14.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "15":
                    imagen = AlimentacionS15.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "16":
                    imagen = AlimentacionS16.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "17":
                    imagen = AlimentacionS17.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "18":
                    imagen = AlimentacionS18.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "19":
                    imagen = AlimentacionS19.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "20":
                    imagen = AlimentacionS20.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "21":
                    imagen = AlimentacionS21.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "22":
                    imagen = AlimentacionS22.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "23":
                    imagen = AlimentacionS23.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
            }

            return imagen;
        }

    }
}
