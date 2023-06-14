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

        /// <summary>
        /// Carga la imagen correspondiente al producto.
        /// </summary>
        /// <param name="contador"></param>
        /// <param name="subCategoria"></param>
        /// <returns>Imagen</returns>
        public static Image obtenerImagen(int contador, int subCategoria)
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
                case 24:
                    image = AlimentacionS24.ResourceManager.GetObject(string.Format("_24_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_24_{contador}".ToString();
                    }
                    break;
                case 25:
                    image = AlimentacionS25.ResourceManager.GetObject(string.Format("_25_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_25_{contador}".ToString();
                    }
                    break;
                case 26:
                    image = AlimentacionS26.ResourceManager.GetObject(string.Format("_26_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_26_{contador}".ToString();
                    }
                    break;
                case 27:
                    image = AlimentacionS27.ResourceManager.GetObject(string.Format("_27_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_27_{contador}".ToString();
                    }
                    break;
                case 28:
                    image = AlimentacionS28.ResourceManager.GetObject(string.Format("_28_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_28_{contador}".ToString();
                    }
                    break;
                case 29:
                    image = AlimentacionS29.ResourceManager.GetObject(string.Format("_29_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_29_{contador}".ToString();
                    }
                    break;
                case 30:
                    image = AlimentacionS30.ResourceManager.GetObject(string.Format("_30_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_30_{contador}".ToString();
                    }
                    break;
                case 31:
                    image = AlimentacionS31.ResourceManager.GetObject(string.Format("_31_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_31_{contador}".ToString();
                    }
                    break;
                case 32:
                    image = AlimentacionS32.ResourceManager.GetObject(string.Format("_32_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_32_{contador}".ToString();
                    }
                    break;
                case 33:
                    image = AlimentacionS33.ResourceManager.GetObject(string.Format("_33_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_33_{contador}".ToString();
                    }
                    break;
                case 34:
                    image = AlimentacionS34.ResourceManager.GetObject(string.Format("_34_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_34_{contador}".ToString();
                    }
                    break;
                case 35:
                    image = AlimentacionS35.ResourceManager.GetObject(string.Format("_35_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_35_{contador}".ToString();
                    }
                    break;
                case 36:
                    image = AlimentacionS36.ResourceManager.GetObject(string.Format("_36_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_36_{contador}".ToString();
                    }
                    break;
                case 37:
                    image = AlimentacionS37.ResourceManager.GetObject(string.Format("_37_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_37_{contador}".ToString();
                    }
                    break;
                case 38:
                    image = AlimentacionS38.ResourceManager.GetObject(string.Format("_38_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_38_{contador}".ToString();
                    }
                    break;
                case 39:
                    image = AlimentacionS39.ResourceManager.GetObject(string.Format("_39_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_39_{contador}".ToString();
                    }
                    break;
                case 40:
                    image = AlimentacionS40.ResourceManager.GetObject(string.Format("_40_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_40_{contador}".ToString();
                    }
                    break;
                case 41:
                    image = AlimentacionS41.ResourceManager.GetObject(string.Format("_41_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_41_{contador}".ToString();
                    }
                    break;
                case 42:
                    image = AlimentacionS42.ResourceManager.GetObject(string.Format("_42_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_42_{contador}".ToString();
                    }
                    break;
                case 43:
                    image = AlimentacionS43.ResourceManager.GetObject(string.Format("_43_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_43_{contador}".ToString();
                    }
                    break;
                case 44:
                    image = AlimentacionS44.ResourceManager.GetObject(string.Format("_44_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_44_{contador}".ToString();
                    }
                    break;
                case 45:
                    image = AlimentacionS45.ResourceManager.GetObject(string.Format("_45_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_45_{contador}".ToString();
                    }
                    break;
                case 46:
                    image = AlimentacionS46.ResourceManager.GetObject(string.Format("_46_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_46_{contador}".ToString();
                    }
                    break;
                case 47:
                    image = AlimentacionS47.ResourceManager.GetObject(string.Format("_47_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_47_{contador}".ToString();
                    }
                    break;
                case 48:
                    image = AlimentacionS48.ResourceManager.GetObject(string.Format("_48_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_48_{contador}".ToString();
                    }
                    break;
                case 49:
                    image = AlimentacionS49.ResourceManager.GetObject(string.Format("_49_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_49_{contador}".ToString();
                    }
                    break;
                case 50:
                    image = AlimentacionS50.ResourceManager.GetObject(string.Format("_50_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_50_{contador}".ToString();
                    }
                    break;
                case 51:
                    image = AlimentacionS51.ResourceManager.GetObject(string.Format("_51_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_51_{contador}".ToString();
                    }
                    break;
                case 52:
                    image = AlimentacionS52.ResourceManager.GetObject(string.Format("_52_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_52_{contador}".ToString();
                    }
                    break;
                case 53:
                    image = AlimentacionS53.ResourceManager.GetObject(string.Format("_53_{0}", contador)) as Image;
                    if (image != null)
                    {
                        image.Tag = $"_53_{contador}".ToString();
                    }
                    break;
            }

            return image;
        }

        /// <summary>
        /// Obtener la imagen desde la base de datos.
        /// </summary>
        /// <param name="rutaImagen"></param>
        /// <returns>Imagen</returns>
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
                case "24":
                    imagen = AlimentacionS24.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "25":
                    imagen = AlimentacionS25.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "26":
                    imagen = AlimentacionS26.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "27":
                    imagen = AlimentacionS27.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "28":
                    imagen = AlimentacionS28.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "29":
                    imagen = AlimentacionS29.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "30":
                    imagen = AlimentacionS30.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "31":
                    imagen = AlimentacionS31.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "32":
                    imagen = AlimentacionS32.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "33":
                    imagen = AlimentacionS33.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "34":
                    imagen = AlimentacionS34.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "35":
                    imagen = AlimentacionS35.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "36":
                    imagen = AlimentacionS36.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "37":
                    imagen = AlimentacionS37.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "38":
                    imagen = AlimentacionS38.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "39":
                    imagen = AlimentacionS39.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "40":
                    imagen = AlimentacionS40.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "41":
                    imagen = AlimentacionS41.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "42":
                    imagen = AlimentacionS42.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "43":
                    imagen = AlimentacionS43.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "44":
                    imagen = AlimentacionS44.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "45":
                    imagen = AlimentacionS45.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "46":
                    imagen = AlimentacionS46.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "47":
                    imagen = AlimentacionS47.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "48":
                    imagen = AlimentacionS48.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "49":
                    imagen = AlimentacionS49.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "50":
                    imagen = AlimentacionS50.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "51":
                    imagen = AlimentacionS51.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "52":
                    imagen = AlimentacionS52.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
                case "53":
                    imagen = AlimentacionS53.ResourceManager.GetObject(rutaImagen) as Image;
                    break;
            }
            return imagen;
        }

    }
}
