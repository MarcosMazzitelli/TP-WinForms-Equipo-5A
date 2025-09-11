using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public static void agregar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
              //  datos.setearConsulta();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                //datos.setearConsulta("Select * FROM ARTICULOS");
                datos.setearConsulta("select A.Id, A.Codigo, A.Nombre, A.Descripcion, C.Descripcion Cat, M.Descripcion Mar From ARTICULOS A, CATEGORIAS C, MARCAS M WHERE IdMarca=M.Id and IdCategoria = C.Id;");
                datos.ejecutarLectura();
                
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    //se castean los objetos que se leen de la base de datos y se asignan a los atributos de aux.
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marca(); //nueva instancia del objeto Marca dentro de la clase Articulo
                    aux.Marca.Descripcion = (string)datos.Lector["Mar"]; //Asignamos valor. Mar es el alias de la consulta sql
                    aux.Categoria = new Categoria(); //nueva instancia del objeto Categoria dentro de la clase Articulo
                    aux.Categoria.Descripcion= (string)datos.Lector["Cat"]; //Asignamos valor. Cat es el alias de la consulta sql
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    //Marca composicion
                    //Categoria composicion
                    //Se asigna una instancia de aux a la lista por cada vuelta.
                    lista.Add(aux);
                }
                datos.cerrarConexion();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
                //cartel de validacion?
            }

        }
    }
}
