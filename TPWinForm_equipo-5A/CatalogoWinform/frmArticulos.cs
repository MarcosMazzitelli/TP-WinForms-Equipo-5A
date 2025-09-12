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
        public frmArticulos()
        {
            InitializeComponent();
        }
   
        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            //El dataSurce,este ve la estructura de la clase y mapea automáticamente las propiedades en columnas
            dgvArticulos.DataSource = negocio.listar();
            //hacer metodo cargar con lo de arriba
            cboCampo.Items.Add("Codigo");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Categoria");
            cboCampo.Items.Add("Precio");


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //abre la ventana de alta articulos y toma el control
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
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
                dgvArticulos.DataSource = articuloNegocio.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
