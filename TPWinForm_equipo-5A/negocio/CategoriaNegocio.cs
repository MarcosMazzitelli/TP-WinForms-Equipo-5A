using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;

namespace negocio
{
    public class CategoriaNegocio
    {
        public void agregar(Categoria nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into CATEGORIAS (Descripcion) values (@descripcion)");
                datos.setearParametro("@descripcion", nuevo.Descripcion);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar una categoria");
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }


        }

        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT Id, Descripcion FROM CATEGORIAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar una categoria");
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }
        public void modificar(Categoria categoria)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update CATEGORIAS set Descripcion = @descripcion where Id = @id");
                datos.setearParametro("@descripcion", categoria.Descripcion);
                datos.setearParametro("@id", categoria.Id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar una categoria");
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void eliminar(int id)
        {
            bool existente = false;
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            List<Articulo> listaArticulos = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            listaArticulos = articuloNegocio.listar();
            try
            {
                foreach (var item in listaArticulos)
                {
                    if (item.Categoria.Id == id)
                    {
                        existente = true;
                    }
                }
                if (existente == true)
                {
                    MessageBox.Show("Operación denegada. Articulos en existencia pertenecientes a la categoria.");
                }
                else
                {
                    DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        datos.setearConsulta("delete from categorias where id = @id");
                        datos.setearParametro("@id", id);
                        datos.ejecutarAccion();
                        MessageBox.Show("Categoria eliminada correctamente");

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar una categoria");
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

    }
}
