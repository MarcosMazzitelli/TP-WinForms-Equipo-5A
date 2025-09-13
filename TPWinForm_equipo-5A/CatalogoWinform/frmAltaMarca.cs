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
    public partial class frmAltaMarca : Form
    {
        private Marca marca = null;
        public frmAltaMarca()
        {
            InitializeComponent();
        }
        public frmAltaMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
            Text = "Modificar marca";
            txtCabeceraMarca.Text = "MODIFICAR MARCA";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                if (marca == null)
                    marca = new Marca();
                marca.Descripcion = txtDescripcionMarca.Text;
                if(marca.Id != 0)
                {
                    marcaNegocio.modificar(marca);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    marcaNegocio.agregar(marca);
                    MessageBox.Show("Agregado exitosamente");
                }

                Close();
    
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaMarca_Load(object sender, EventArgs e)
        {
            try
            {
                if(marca != null)
                {
                    txtDescripcionMarca.Text = marca.Descripcion;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
