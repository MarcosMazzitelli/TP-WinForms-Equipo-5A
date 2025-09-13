using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
        ///ATRIBUTOS
        private Articulo articulo = null;
        public List<String> imagenes;
        private int indiceImagenActual;

        ///CONSTRUCTORES
        public frmAltaArticulo() // click al boton agregar se va a ejecutar el primer constructor con articulo Null
        {
            InitializeComponent();
            imagenes = new List<string>();
            indiceImagenActual = 0;
            pbxAgregarImagen.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSUwCJYSnbBLMEGWKfSnWRGC_34iCCKkxePpg&s");

        }
        public frmAltaArticulo(Articulo articulo) //click modificar: se ejecuta el segundo constructor con un articulo
        {
            InitializeComponent();
            imagenes = new List<string>();
            this.articulo = articulo;
            indiceImagenActual = 0; 
            Text = "Modificar Articulo";
            txtCabeceraArticulo.Text = "MODIFICAR ARTICULO";
        }

        ///METODOS
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
                    ArticuloNegocio.agregar(articulo, imagenes);
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

                if (articulo != null) //Si el articulo ya existe, tremos los valores de los atributos del objeto a los textBox y a los cbo
                {
                    txtCodigo.Text = articulo.Codigo.ToString();
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString();
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                    cboMarca.SelectedValue = articulo.Marca.Id;
                    //cargarImagen()
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            //cargar imagen cuando sale del campo txtbox
            cargarImagen(txtUrlImagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxAgregarImagen.Load(imagen);

            }
            catch (Exception ex)
            {
                pbxAgregarImagen.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSUwCJYSnbBLMEGWKfSnWRGC_34iCCKkxePpg&s");
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            imagenes.Add(txtUrlImagen.Text);
            txtUrlImagen.Clear();
            if(imagenes.Count > 0)
            {
                
            }

        }

        private void btnSiguienteImg_Click(object sender, EventArgs e)
        {
            try
            {
                if (indiceImagenActual < imagenes.Count -1)
                {
                    indiceImagenActual++;
                    cargarImagen(imagenes[indiceImagenActual]);
                }
                else
                {
                    MessageBox.Show("Es la última imagen!");
                    
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAnteriorImg_Click(object sender, EventArgs e)
        {
            try
            {

                if (indiceImagenActual > 0)
                {
                    indiceImagenActual--;
                    cargarImagen(imagenes[indiceImagenActual]);
                }
                else
                {
                    MessageBox.Show("Es la primera imagen!");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
