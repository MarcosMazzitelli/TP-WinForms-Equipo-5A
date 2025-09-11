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
    public partial class frmAltaCategoria : Form
    {
        public frmAltaCategoria()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();

            categoria.Descripcion = txtDescripcionCategoria.Text;

            CategoriaNegocio.agregar(categoria);
            MessageBox.Show("Agregado exitosamente");
            Close();

        }
    }
}
