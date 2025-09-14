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
    public partial class frmDetalleArticulo : Form
    {
        List<Imagen> listaImagenes;
        Articulo articuloSeleccionado;
        private int indiceImagenActual = 0;


        public frmDetalleArticulo()
        {
            InitializeComponent();
        }

        public frmDetalleArticulo(Articulo articuloSeleccionado, List<Imagen> listaImagenes)
        {
            InitializeComponent();
            this.listaImagenes = listaImagenes;
            this.articuloSeleccionado = articuloSeleccionado;
            mostrarImagenActual();
            txtCodigo.Text = articuloSeleccionado.Codigo;
            txtNombre.Text = articuloSeleccionado.Nombre;
            txtDescripcion.Text = articuloSeleccionado.Descripcion;
            txtMarca.Text = articuloSeleccionado.Marca.Descripcion;
            txtCategoria.Text = articuloSeleccionado.Categoria.Descripcion;
            txtPrecio.Text = "$" + articuloSeleccionado.Precio.ToString();

        }



        private void frmDetalleArticulo_Load(object sender, EventArgs e)
        {
            
        }

        private void cargarBotones()
        {

            // Si no hay imágenes, esconder todos los botones relacionados
            if (listaImagenes.Count == 0)
            {
                btnAnteriorImg.Visible = false;
                btnSiguienteImg.Visible = false;
                //sino hay imagenes no se ejecuta nada de lo de abajo por el return.
                return;
            }


            // Boton anterior visible solo si hay una imagen antes
            if (indiceImagenActual > 0)
                btnAnteriorImg.Visible = true;
            else
                btnAnteriorImg.Visible = false;

            // Boton siguiente visible solo si hay una imagen después
            if (indiceImagenActual < listaImagenes.Count - 1)
                btnSiguienteImg.Visible = true;
            else
                btnSiguienteImg.Visible = false;
        }

        private void MostrarImagenPorDefecto()
        {
            pbxImagen.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSUwCJYSnbBLMEGWKfSnWRGC_34iCCKkxePpg&s");
        }
        private void mostrarImagenActual()
        {
            cargarBotones();
            if (listaImagenes != null && listaImagenes.Count > 0)
            {
                // Si no hay imágenes, mostramos imagen por defecto y deshabilitamos botones
                if (listaImagenes == null || listaImagenes.Count == 0)
                {
                    MostrarImagenPorDefecto();
                    btnAnteriorImg.Visible = false;
                    btnSiguienteImg.Visible = false;
                    return;
                }

                try
                {

                    pbxImagen.Load(listaImagenes[indiceImagenActual].Url);
                }
                catch
                {
                    MostrarImagenPorDefecto();
                }
            }
            else
            {
                MostrarImagenPorDefecto();
            }

        }

        private void btnAnteriorImg_Click(object sender, EventArgs e)
        {
            if (listaImagenes == null || listaImagenes.Count == 0)
                return; //si se cumple la condicion se sale del metodo y no se ejecutan las instrucciones de abajo

            indiceImagenActual--;
            if (indiceImagenActual < 0)
                indiceImagenActual = listaImagenes.Count - 1; // vuelve al final

            mostrarImagenActual();
        }
        private void btnSiguienteImg_Click(object sender, EventArgs e)
        {
            if (listaImagenes == null || listaImagenes.Count == 0)
                return; //si se cumple la condicion se sale del metodo y no se ejecutan las instrucciones de abajo

            indiceImagenActual++;
            if (indiceImagenActual >= listaImagenes.Count)
                indiceImagenActual = 0; // vuelve al principio

            mostrarImagenActual();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
