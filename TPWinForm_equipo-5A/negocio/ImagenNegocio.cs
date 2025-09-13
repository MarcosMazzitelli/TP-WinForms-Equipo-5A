﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ImagenNegocio
    {
        public List<Imagen> listImagenes()
        {
            List<Imagen> listaImagenes = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT Id, IdArticulo, ImagenUrl FROM IMAGENES;");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Imagen auxImg = new Imagen();
                    auxImg.Id = (int)datos.Lector["Id"];
                    auxImg.IdArticulo = (int)datos.Lector["IdArticulo"];
                    auxImg.Url = (string)datos.Lector["ImagenUrl"];
                    listaImagenes.Add(auxImg);
                }
                datos.cerrarConexion();
                return listaImagenes;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
