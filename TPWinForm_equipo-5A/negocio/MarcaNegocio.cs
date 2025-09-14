using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace negocio
{
    public class MarcaNegocio
    {
        public void modificar(Marca marca)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update MARCAS set Descripcion = @descripcion where Id = @id");
                datos.setearParametro("@descripcion",marca.Descripcion);
                datos.setearParametro("@id", marca.Id);
                datos.ejecutarAccion();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al modificar una marca");
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void agregar(Marca nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into MARCAS (Descripcion) values (@descripcion)");
                datos.setearParametro("@descripcion", nuevo.Descripcion);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar una marca");
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }


        }
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT Id, Descripcion FROM MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar una marca");
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
                    if (item.Marca.Id == id)
                    {
                        existente = true;
                    }
                }
                if (existente == true)
                {
                    MessageBox.Show("Operación denegada. Articulos en existencia pertenecnientes a la marca.");
                }
                else
                {
                    DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        datos.setearConsulta("delete from marcas where id = @id");
                        datos.setearParametro("@id", id);
                        datos.ejecutarAccion();
                        MessageBox.Show("Marca eliminada correctamente");

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar una marca");
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }


}
