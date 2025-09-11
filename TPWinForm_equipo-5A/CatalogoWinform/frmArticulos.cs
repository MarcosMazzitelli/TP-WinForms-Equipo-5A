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
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //abre la ventana de alta articulos y toma el control
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategorias ventanaCategorias= new frmCategorias();
            ventanaCategorias.ShowDialog();
        }
    }
}
