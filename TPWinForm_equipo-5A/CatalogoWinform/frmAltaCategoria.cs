using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoWinform
{
    public partial class frmAltaCategoria : Form
    {
        private Categoria categoria = null;
        public frmAltaCategoria()
        {
            InitializeComponent();
            Text = "Alta categoria";
        }
        public frmAltaCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            Text = "Modificar categoria";
            txtCabeceraCategoria.Text = "MODIFICAR CATEGORIA";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
        
          CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                if (categoria == null)
                    categoria = new Categoria();
                    categoria.Descripcion = txtDescripcionCategoria.Text;
                if (categoria.Id != 0)
                {
                    categoriaNegocio.modificar(categoria);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    categoriaNegocio.agregar(categoria);
                    MessageBox.Show("Agregado exitosamente");
                }
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAltaCategoria_Load(object sender, EventArgs e)
        {
            try
            {
                if (categoria != null)
                {
                    txtDescripcionCategoria.Text = categoria.Descripcion;

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
