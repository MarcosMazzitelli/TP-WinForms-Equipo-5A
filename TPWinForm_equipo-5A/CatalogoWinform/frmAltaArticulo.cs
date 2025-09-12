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
using static System.Windows.Forms.LinkLabel;

namespace CatalogoWinform
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null; 
        public frmAltaArticulo() // click al boton agregar se va a ejecutar el primer constructor con articulo Null
        {
            InitializeComponent();
        }
        public frmAltaArticulo(Articulo articulo) //click modificar: se ejecuta el segundo constructor con un articulo
        {
            InitializeComponent();
            this.articulo = articulo;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Articulo articulo = new Articulo();

            try
            {
                if (articulo == null)
                    articulo = new Articulo();
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                //Captura el object de la lista desplegable y lo castea a Categoria (el object tiene ID y Descripcion)
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                //Captura el object de la lista desplegable y lo castea a Marca (el object tiene ID y Descripcion)
                articulo.Marca = (Marca)cboMarca.SelectedItem;


                if (articulo.Id != 0)
                {
                    ArticuloNegocio.modificar(articulo);
                    MessageBox.Show("Modificdo exitosamente");
                }
                else
                {
                    ArticuloNegocio.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");
                }
                
                
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "Id"; //Nombre de los atributos de la clase Categoria. Asigno valor que va a tomar
                cboCategoria.DisplayMember = "Descripcion"; //Nombre de los atributos de la clase Categoria. Asigno valor que va a mostrar
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "Id"; //Nombre de los atributos de la clase Marca. Asigno valor que va a tomar
                cboMarca.DisplayMember = "Descripcion"; //Nombre de los atributos de la clase Marca. Asigno valor que va a mostrar

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo.ToString();
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString();
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                    cboMarca.SelectedValue = articulo.Marca.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
