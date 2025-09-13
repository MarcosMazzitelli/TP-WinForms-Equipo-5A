using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
            cargarBotones();
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
            txtUrlImagen.Enabled = false;
            //imagenes
            indiceImagenActual = 0;
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            List<Imagen> listaImagenes = new List<Imagen>();

            listaImagenes = imagenNegocio.listImagenes();
            //expresion lambda para traer solo imagenes asociadas al articulo recibido por parametro
            listaImagenes = listaImagenes.FindAll(img => img.IdArticulo == articulo.Id);
            foreach (var img in listaImagenes)
            {
                //en cada vuelta de la lista de imagenes asociadas, se asigna a la lista de urls (atributo del formulario)
                imagenes.Add(img.Url);
            }
            cargarBotones();
            try
            {
                if (listaImagenes.Count > 0)
                {
                    pbxAgregarImagen.Load(imagenes.First());
                }
                else
                {
                    MostrarImagenPorDefecto();
                }
            }
            catch (Exception ex)
            {
                MostrarImagenPorDefecto();
            }
        }

        ///METODOS
        private void MostrarImagenPorDefecto()
        {
            pbxAgregarImagen.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSUwCJYSnbBLMEGWKfSnWRGC_34iCCKkxePpg&s");
        }

        private void cargarBotones()
        {

            // Si no hay imágenes, esconder todos los botones relacionados
            if (imagenes.Count == 0)
            {
                btnAnteriorImg.Visible = false;
                btnSiguienteImg.Visible = false;
                btnQuitarImagen.Visible = false;
                //sino hay imagenes no se ejecuta nada de lo de abajo por el return.
                return;
            }

            // Si hay al menos una imagen, habilitamos quitar
            btnQuitarImagen.Visible = true;

            // Anterior visible solo si hay una imagen antes
            if(indiceImagenActual > 0)
                btnAnteriorImg.Visible = true;
            else
            btnAnteriorImg.Visible = false;

            // Siguiente visible solo si hay una imagen después
            if (indiceImagenActual < imagenes.Count - 1)
                btnSiguienteImg.Visible = true;
            else
                btnSiguienteImg.Visible = false;

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
                MostrarImagenPorDefecto();
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            imagenes.Add(txtUrlImagen.Text);
            txtUrlImagen.Clear();
            indiceImagenActual = imagenes.Count -1; //se posiciona el indice en el ultimo registro de la lista.
            cargarImagen(imagenes[indiceImagenActual]);
            cargarBotones();

        }
        private void btnQuitarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                imagenes.Remove(imagenes[indiceImagenActual]);
                // Si ya no hay imágenes luego de eliminar.
                if (imagenes.Count == 0)
                {
                    indiceImagenActual = 0;
                    MostrarImagenPorDefecto();
                    txtUrlImagen.Clear();
                }
                else
                {
                    // Si el índice quedó fuera de rango, ajustar al último
                    if (indiceImagenActual >= imagenes.Count)
                        indiceImagenActual = imagenes.Count - 1;

                    // Cargar la imagen en la nueva posición
                    cargarImagen(imagenes[indiceImagenActual]);
                    txtUrlImagen.Text = imagenes[indiceImagenActual];
                }
                cargarBotones();
                /*  //Si el indice es mayor a 0 pero tambien es la ultima imagen, hay que restar si o si
                if(indiceImagenActual > 0 && indiceImagenActual == imagenes.Count)
                {
                    indiceImagenActual--;
                }
                if (indiceImagenActual == 0 && imagenes.Count != 1)
                {
                    indiceImagenActual++;
                }
                cargarImagen(imagenes[indiceImagenActual]);
                cargarBotones();
                txtUrlImagen.Clear();
            }*/
            }
            catch (Exception)
            {
                MostrarImagenPorDefecto();

            }

        }


        private void btnSiguienteImg_Click(object sender, EventArgs e)
        {
            try
            {
                //si el indice actual es menor a la cantidad de imagenes en la lista -1 (porque el indice arranca en 0) significa que 
                if (indiceImagenActual < imagenes.Count -1)
                {
                    indiceImagenActual++;
                    cargarImagen(imagenes[indiceImagenActual]);
                    cargarBotones();
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
                    cargarBotones();
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
