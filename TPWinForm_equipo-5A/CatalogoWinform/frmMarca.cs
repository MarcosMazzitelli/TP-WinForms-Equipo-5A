using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoWinform
{
    public partial class frmMarca : Form
    {
        public frmMarca()
        {
            InitializeComponent();
        }

        private void frmMarca_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            dgvMarca.DataSource = marcaNegocio.listar();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaMarca altaMarca = new frmAltaMarca();
            altaMarca.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Marca seleccionado;
            seleccionado = (Marca)dgvMarca.CurrentRow.DataBoundItem;
            frmAltaMarca modificarMarca = new frmAltaMarca(seleccionado);
            modificarMarca.ShowDialog();
            cargar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            Marca seleccionado;
            seleccionado = (Marca)dgvMarca.CurrentRow.DataBoundItem;
            marcaNegocio.eliminar(seleccionado.Id);
            cargar();

        }
    }
}
