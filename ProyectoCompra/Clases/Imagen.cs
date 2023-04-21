﻿using ProyectoCompra.Properties;
using System.Collections.Generic;
using System.Drawing;
using System.Resources;

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
            }
            return imagen;
        }

    }
}
