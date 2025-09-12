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
        private List<Articulo> listaArticulos;
        public frmArticulos()
        {
            InitializeComponent();
        }
   
        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            //El dataSurce,este ve la estructura de la clase y mapea automáticamente las propiedades en columnas
            dgvArticulos.DataSource = negocio.listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //abre la ventana de alta articulos y toma el control
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargar();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategorias ventanaCategorias = new frmCategorias();
            ventanaCategorias.ShowDialog();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            Articulo seleccionado; // Creamos objeto Articulo donde guardaremos seleccion
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem; // devolvemos un objeto Articulo casteadolo, desde la fila del dataGridView donde nos posicionamos
            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            cargar();
        }
        private void cargar() //actualizar tablas
        {
            ArticuloNegocio articuloNegocio= new ArticuloNegocio();
            try
            {
                listaArticulos = articuloNegocio.listar(); 
                dgvArticulos.DataSource = listaArticulos;
      
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
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem; // Guardamos el objeto en el que nos posicionamos en la fila de la tabla
                articuloNegocio.eliminar(seleccionado.Id); // eliminamos enviando el id por parametro 
                cargar();

            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}
