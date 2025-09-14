using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace CatalogoWinform
{
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            dgvCategorias.DataSource = categoriaNegocio.listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaCategoria altaCategoria = new frmAltaCategoria();
            altaCategoria.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Categoria seleccionado;
            seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            frmAltaCategoria modificarCategoria = new frmAltaCategoria(seleccionado);
            modificarCategoria.ShowDialog();
            cargar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            Categoria seleccion;
            seleccion = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            CategoriaNegocio categoriaNegocio= new CategoriaNegocio();
            categoriaNegocio.eliminar(seleccion.Id);
            cargar();
        }
    }
}
