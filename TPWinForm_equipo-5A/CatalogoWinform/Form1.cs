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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            //El dataSurce,este ve la estructura de la clase y mapea automáticamente las propiedades en columnas
            dgvArticulos.DataSource = negocio.listar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //abre la ventana de alta articulos y toma el control
            //frmAltaArticulo modificar = new frmAltaArticulo();
           // modificar.ShowDialog();
        }
    }
}
