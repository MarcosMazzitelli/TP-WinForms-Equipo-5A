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
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            dgvCategorias.DataSource = categoriaNegocio.listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaCategoria altaCategoria = new frmAltaCategoria();
            altaCategoria.ShowDialog();
        }
    }
}
