using System;
using System.CodeDom;
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

        public static void modificar (Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IDCategoria= @IdCategoria, Precio = @precio where id = @id;");
                datos.setearParametro("@codigo", articulo.Codigo);
                datos.setearParametro("@nombre", articulo.Nombre);
                datos.setearParametro("@Descripcion", articulo.Descripcion);
                datos.setearParametro("@IdMarca", articulo.Marca.Id);
                datos.setearParametro("@IdCategoria", articulo.Categoria.Id);
                datos.setearParametro("@precio", articulo.Precio);
                datos.setearParametro("@id", articulo.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                //datos.setearConsulta("Select * FROM ARTICULOS");
                datos.setearConsulta("select A.Id, A.Codigo, A.Nombre, A.Descripcion, C.Descripcion Cat, M.Descripcion Mar, C.Id IdCat, M.Id IdMar, A.Precio From ARTICULOS A, CATEGORIAS C, MARCAS M WHERE A.IdMarca=M.Id and A.IdCategoria = C.Id;");
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
                    aux.Categoria.Id = (int)datos.Lector["IdCat"]; //Asignamos valor a Id Categoria para poder utilizarlo en el modificar (cboCategoria.SelectedValue)
                    aux.Marca.Id = (int)datos.Lector["IdMar"]; // Asignamos valor a Id Marca para poder utilizarlo en el modificar (cboMarca.SelectedValue)
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
