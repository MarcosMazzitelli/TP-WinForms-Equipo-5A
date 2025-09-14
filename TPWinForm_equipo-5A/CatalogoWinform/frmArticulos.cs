using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;


namespace CatalogoWinform
{
    public partial class frmArticulos : Form
    {
        //Atributos
        private List<Articulo> listaArticulos;
        List<Imagen> listaImagenes;
        private int indiceImagenActual = 0; 

        //Constructores
        public frmArticulos()
        {
            InitializeComponent();
        }

        //Metodos
        private void MostrarImagenPorDefecto()
        {
            pbxImagenListado.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSUwCJYSnbBLMEGWKfSnWRGC_34iCCKkxePpg&s");
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            cargar();
            cboCampo.Items.Add("Codigo");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Categoria");
            cboCampo.Items.Add("Precio");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //abre la ventana de alta articulos y toma el control
            frmAltaArticulo alta = new frmAltaArticulo();
            this.Hide();
            alta.ShowDialog();
            this.Show();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            Articulo seleccionado; // Creamos objeto Articulo donde guardaremos seleccion
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem; // devolvemos un objeto Articulo casteadolo, desde la fila del dataGridView donde nos posicionamos
            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            this.Hide();
            modificar.ShowDialog();
            this.Show();
            cargar();
        }
        private void cargar() //actualizar tablas
        {
            ArticuloNegocio articuloNegocio= new ArticuloNegocio();
            try
            {
                listaArticulos = articuloNegocio.listar(); 
                dgvArticulos.DataSource = listaArticulos;
                ocultarColumnas();


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private void btnEliminarFisicamente_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio(); //creo objeto negocioArticulo para poder utilizar metodo
            Articulo seleccionado; //Intsancia objeto articulo
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem; // Guardamos el objeto en el que nos posicionamos en la fila de la tabla
                    articuloNegocio.eliminar(seleccionado.Id); // eliminamos enviando el id por parametro
                    MessageBox.Show("Eliminado correctamente", "Aviso");
                    cargar();
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();

            //Campos numericos
            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            //Campos string
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                //filtrar retorna una lista que se asigna al dataGridView.
                dgvArticulos.DataSource = articuloNegocio.filtrar(campo, criterio, filtro);
                ocultarColumnas();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null)
                return;

            ImagenNegocio imagenNegocio = new ImagenNegocio();
            Articulo articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            listaImagenes = imagenNegocio.listImagenes();
            //expresion lambda para traer solo imagenes asociadas al articulo recibido por parametro
            listaImagenes = listaImagenes.FindAll(img => img.IdArticulo == articuloSeleccionado.Id);
            indiceImagenActual = 0;
            mostrarImagenActual();

        }

        private void mostrarImagenActual()
        {
            cargarBotones();
            if (listaImagenes != null && listaImagenes.Count > 0)
            {
                // Si no hay imágenes, mostramos imagen por defecto y deshabilitamos botones
                if (listaImagenes == null || listaImagenes.Count == 0)
                {
                    MostrarImagenPorDefecto();
                    btnAnteriorImg.Visible = false;
                    btnSiguienteImg.Visible = false;
                    return;
                }

                try
                {

                    pbxImagenListado.Load(listaImagenes[indiceImagenActual].Url);
                }
                catch
                {
                    MostrarImagenPorDefecto();
                }
            }
            else
            {
                MostrarImagenPorDefecto();
            }

        }

        private void cargarBotones()
        {

            // Si no hay imágenes, esconder todos los botones relacionados
            if (listaImagenes.Count == 0)
            {
                btnAnteriorImg.Visible = false;
                btnSiguienteImg.Visible = false;
                //sino hay imagenes no se ejecuta nada de lo de abajo por el return.
                return;
            }


            // Boton anterior visible solo si hay una imagen antes
            if (indiceImagenActual > 0)
                btnAnteriorImg.Visible = true;
            else
                btnAnteriorImg.Visible = false;

            // Boton siguiente visible solo si hay una imagen después
            if (indiceImagenActual < listaImagenes.Count - 1)
                btnSiguienteImg.Visible = true;
            else
                btnSiguienteImg.Visible = false;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (listaImagenes == null || listaImagenes.Count == 0) 
                return; //si se cumple la condicion se sale del metodo y no se ejecutan las instrucciones de abajo

            indiceImagenActual--;
            if (indiceImagenActual < 0)
                indiceImagenActual = listaImagenes.Count - 1; // vuelve al final

            mostrarImagenActual();

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (listaImagenes == null || listaImagenes.Count == 0) 
                return; //si se cumple la condicion se sale del metodo y no se ejecutan las instrucciones de abajo

            indiceImagenActual++;
            if (indiceImagenActual >= listaImagenes.Count)
                indiceImagenActual = 0; // vuelve al principio

            mostrarImagenActual();

        }

        private void btnMenuCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias ventanaCategorias = new frmCategorias();
            this.Hide();
            ventanaCategorias.ShowDialog();
            this.Show();

        }

        private void btnMenuMarcas_Click(object sender, EventArgs e)
        {
            frmMarca ventanaMarca = new frmMarca();
            this.Hide();
            ventanaMarca.ShowDialog();
            this.Show();

        }

        private void btnVerDetalleArticulo_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null)
                return;

            ImagenNegocio imagenNegocio = new ImagenNegocio();
            Articulo articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            listaImagenes = imagenNegocio.listImagenes();
            //expresion lambda para traer solo imagenes asociadas al articulo recibido por parametro
            listaImagenes = listaImagenes.FindAll(img => img.IdArticulo == articuloSeleccionado.Id);
            frmDetalleArticulo ventanaDetalleArticulo = new frmDetalleArticulo(articuloSeleccionado, listaImagenes);
            this.Hide();
            ventanaDetalleArticulo.ShowDialog();
            this.Show();
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;

        }
    }
}
