using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public static void agregar(Articulo nuevo, List<Imagen> imagenes)
        {
            AccesoDatos datos = new AccesoDatos();
            List<Imagen> listaImagenes = new List<Imagen>();

            try
            {
                datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) output inserted.Id values (@codigo,@nombre,@descripcion,@idMarca,@idCategoria,@precio)");
 // Parametros (@Clave, valor) clave seria el nombre de la columna y valor el lo que tiene el objeto recibido por parametro en cada atributo
                datos.setearParametro("@codigo", nuevo.Codigo);
                datos.setearParametro("@nombre", nuevo.Nombre);
                datos.setearParametro("@descripcion", nuevo.Descripcion);
                datos.setearParametro("@idMarca", nuevo.Marca.Id);
                datos.setearParametro("@idCategoria", nuevo.Categoria.Id);
                datos.setearParametro("@precio", nuevo.Precio);
                //falta setear imagenes
                int idArticulo = datos.ejecutarEscalar();
                datos.cerrarConexion();

                foreach (Imagen img in imagenes)
                {
                    AccesoDatos datosImagen = new AccesoDatos();
                    datosImagen.setearConsulta("Insert Into IMAGENES (IdArticulo, ImagenUrl) Values (@idArticulo,@imagenUrl)");
                    datosImagen.setearParametro("@idArticulo", idArticulo);
                    datosImagen.setearParametro("@imagenUrl", img.Url);
                    datosImagen.ejecutarAccion(); //s
                    datosImagen.cerrarConexion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar un articulo");
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public static void modificar (Articulo articulo, List<Imagen> imagenes)
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
                // IMAGENES
                // Se borran todas las imágenes de ese artículo y se vuelven a insertar las actuales
                AccesoDatos datosDelete = new AccesoDatos();
                datosDelete.setearConsulta("DELETE FROM IMAGENES WHERE IdArticulo = @idArticulo");
                datosDelete.setearParametro("@idArticulo", articulo.Id);
                datosDelete.ejecutarAccion();
                datosDelete.cerrarConexion();

                foreach (Imagen img in imagenes)
                {
                    AccesoDatos datosImg = new AccesoDatos();
                    datosImg.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@idArticulo, @imagenUrl)");
                    datosImg.setearParametro("@idArticulo", articulo.Id);
                    datosImg.setearParametro("@imagenUrl", img.Url);
                    datosImg.ejecutarAccion();
                    datosImg.cerrarConexion();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar un articulo");
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {

            List<Articulo> lista = new List<Articulo>();

            AccesoDatos datos = new AccesoDatos();

            try
            {
                //falta agregar las imagenes a la consulta.
                string consulta = "select A.Id, A.Codigo, A.Nombre, A.Descripcion, C.Descripcion Cat, M.Descripcion Mar, C.Id IdCat, M.Id IdMar, A.Precio From ARTICULOS A, CATEGORIAS C, MARCAS M WHERE A.IdMarca=M.Id and A.IdCategoria = C.Id And ";
                switch (campo)
                {
                    case "Precio":
                        switch (criterio)
                        {
                            case "Mayor a":
                                consulta += "A.Precio > " + filtro;
                                break;
                            case "Menor a":
                                consulta += "A.Precio < " + filtro;
                                break;
                            default: //Igual a
                                consulta += "A.Precio = " + filtro;
                                break;
                        }

                        break;

                    case "Codigo":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "A.Codigo like '" + filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += "A.Codigo like '%" + filtro + "'";
                                break;
                            default: //contiene
                                consulta += "A.Codigo like '%" + filtro + "%'"; 
                                break;
                        }

                        break;
                    case "Nombre":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "A.Nombre like '" + filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += "A.Nombre like '%" + filtro + "'";
                                break;
                            default: //contiene
                                consulta += "A.Nombre like '%" + filtro + "%'";
                                break;
                        }

                        break;

                    case "Categoria":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "C.Descripcion like '" + filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += "C.Descripcion like '%" + filtro + "'";
                                break;
                            default: //contiene
                                consulta += "C.Descripcion like '%" + filtro + "%'";
                                break;
                        }
                        break;
                }
                datos.setearConsulta(consulta);
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
                    aux.Categoria.Descripcion = (string)datos.Lector["Cat"]; //Asignamos valor. Cat es el alias de la consulta sql
                    aux.Categoria.Id = (int)datos.Lector["IdCat"]; //Asignamos valor a Id Categoria para poder utilizarlo en el modificar (cboCategoria.SelectedValue)
                    aux.Marca.Id = (int)datos.Lector["IdMar"]; // Asignamos valor a Id Marca para poder utilizarlo en el modificar (cboMarca.SelectedValue)
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    //Marca composicion
                    //Categoria composicion
                    //Se asigna una instancia de aux a la lista por cada vuelta.
                    lista.Add(aux);
                }


                return lista;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar un articulo");
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
                    //Se asigna una instancia de aux a la lista por cada vuelta.
                    lista.Add(aux);
                }
                datos.cerrarConexion();
                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar un articulo");
                throw ex;
            }

        }

        public void eliminar(int id)
        {
            
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from articulos where id = @id;");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();

                // IMAGENES
                // Se borran todas las imágenes de ese artículo
                AccesoDatos datosDelete = new AccesoDatos();
                datosDelete.setearConsulta("DELETE FROM IMAGENES WHERE IdArticulo = @idArticulo");
                datosDelete.setearParametro("@idArticulo", id);
                datosDelete.ejecutarAccion();
                datosDelete.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar un articulo");
                throw ex;
            }
        }
    }
}
