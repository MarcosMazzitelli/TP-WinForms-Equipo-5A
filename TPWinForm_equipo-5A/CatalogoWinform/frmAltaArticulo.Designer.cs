namespace CatalogoWinform
{
    partial class frmAltaArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.pbxAgregarImagen = new System.Windows.Forms.PictureBox();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.btnQuitarImagen = new System.Windows.Forms.Button();
            this.btnSiguienteImg = new System.Windows.Forms.Button();
            this.btnAnteriorImg = new System.Windows.Forms.Button();
            this.txtCabeceraArticulo = new System.Windows.Forms.Label();
            this.lblReqCodigo = new System.Windows.Forms.Label();
            this.lblReqNombre = new System.Windows.Forms.Label();
            this.lblReqDescripcion = new System.Windows.Forms.Label();
            this.lblReqPrecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregarImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblCodigo.Location = new System.Drawing.Point(50, 86);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(60, 19);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(42, 124);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 19);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.Location = new System.Drawing.Point(21, 157);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(92, 19);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(110, 87);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(110, 123);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(110, 158);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(121, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.Location = new System.Drawing.Point(133, 377);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(88, 28);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.Location = new System.Drawing.Point(256, 377);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 28);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblPrecio.Location = new System.Drawing.Point(53, 229);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(56, 19);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(110, 230);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 20);
            this.txtPrecio.TabIndex = 4;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblMarca.Location = new System.Drawing.Point(53, 264);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(56, 19);
            this.lblMarca.TabIndex = 10;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblCategoria.Location = new System.Drawing.Point(31, 305);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(78, 19);
            this.lblCategoria.TabIndex = 11;
            this.lblCategoria.Text = "Categoria:";
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(110, 264);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(121, 21);
            this.cboMarca.TabIndex = 5;
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(110, 305);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 6;
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblUrlImagen.Location = new System.Drawing.Point(16, 195);
            this.lblUrlImagen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(93, 19);
            this.lblUrlImagen.TabIndex = 15;
            this.lblUrlImagen.Text = "URL Imagen:";
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(110, 196);
            this.txtUrlImagen.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(121, 20);
            this.txtUrlImagen.TabIndex = 3;
            this.txtUrlImagen.Leave += new System.EventHandler(this.txtUrlImagen_Leave);
            // 
            // pbxAgregarImagen
            // 
            this.pbxAgregarImagen.Location = new System.Drawing.Point(258, 69);
            this.pbxAgregarImagen.Margin = new System.Windows.Forms.Padding(2);
            this.pbxAgregarImagen.Name = "pbxAgregarImagen";
            this.pbxAgregarImagen.Size = new System.Drawing.Size(201, 176);
            this.pbxAgregarImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAgregarImagen.TabIndex = 17;
            this.pbxAgregarImagen.TabStop = false;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Location = new System.Drawing.Point(330, 249);
            this.btnAgregarImagen.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(16, 19);
            this.btnAgregarImagen.TabIndex = 7;
            this.btnAgregarImagen.Text = "✓";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // btnQuitarImagen
            // 
            this.btnQuitarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarImagen.Location = new System.Drawing.Point(359, 249);
            this.btnQuitarImagen.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitarImagen.Name = "btnQuitarImagen";
            this.btnQuitarImagen.Size = new System.Drawing.Size(16, 19);
            this.btnQuitarImagen.TabIndex = 8;
            this.btnQuitarImagen.Text = "x";
            this.btnQuitarImagen.UseVisualStyleBackColor = true;
            this.btnQuitarImagen.Click += new System.EventHandler(this.btnQuitarImagen_Click);
            // 
            // btnSiguienteImg
            // 
            this.btnSiguienteImg.BackColor = System.Drawing.SystemColors.Control;
            this.btnSiguienteImg.Location = new System.Drawing.Point(413, 256);
            this.btnSiguienteImg.Margin = new System.Windows.Forms.Padding(2);
            this.btnSiguienteImg.Name = "btnSiguienteImg";
            this.btnSiguienteImg.Size = new System.Drawing.Size(17, 19);
            this.btnSiguienteImg.TabIndex = 18;
            this.btnSiguienteImg.Text = ">";
            this.btnSiguienteImg.UseVisualStyleBackColor = false;
            this.btnSiguienteImg.Click += new System.EventHandler(this.btnSiguienteImg_Click);
            // 
            // btnAnteriorImg
            // 
            this.btnAnteriorImg.BackColor = System.Drawing.SystemColors.Control;
            this.btnAnteriorImg.Location = new System.Drawing.Point(274, 256);
            this.btnAnteriorImg.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnteriorImg.Name = "btnAnteriorImg";
            this.btnAnteriorImg.Size = new System.Drawing.Size(17, 19);
            this.btnAnteriorImg.TabIndex = 19;
            this.btnAnteriorImg.Text = "<";
            this.btnAnteriorImg.UseVisualStyleBackColor = false;
            this.btnAnteriorImg.Click += new System.EventHandler(this.btnAnteriorImg_Click);
            // 
            // txtCabeceraArticulo
            // 
            this.txtCabeceraArticulo.AutoSize = true;
            this.txtCabeceraArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtCabeceraArticulo.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Bold);
            this.txtCabeceraArticulo.ForeColor = System.Drawing.Color.Black;
            this.txtCabeceraArticulo.Location = new System.Drawing.Point(9, 16);
            this.txtCabeceraArticulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtCabeceraArticulo.Name = "txtCabeceraArticulo";
            this.txtCabeceraArticulo.Size = new System.Drawing.Size(181, 24);
            this.txtCabeceraArticulo.TabIndex = 7;
            this.txtCabeceraArticulo.Text = "Alta nuevo articulo";
            this.txtCabeceraArticulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblReqCodigo
            // 
            this.lblReqCodigo.AutoSize = true;
            this.lblReqCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqCodigo.ForeColor = System.Drawing.Color.Red;
            this.lblReqCodigo.Location = new System.Drawing.Point(40, 90);
            this.lblReqCodigo.MaximumSize = new System.Drawing.Size(25, 25);
            this.lblReqCodigo.Name = "lblReqCodigo";
            this.lblReqCodigo.Size = new System.Drawing.Size(13, 16);
            this.lblReqCodigo.TabIndex = 20;
            this.lblReqCodigo.Text = "*";
            // 
            // lblReqNombre
            // 
            this.lblReqNombre.AutoSize = true;
            this.lblReqNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqNombre.ForeColor = System.Drawing.Color.Red;
            this.lblReqNombre.Location = new System.Drawing.Point(32, 130);
            this.lblReqNombre.Name = "lblReqNombre";
            this.lblReqNombre.Size = new System.Drawing.Size(13, 16);
            this.lblReqNombre.TabIndex = 21;
            this.lblReqNombre.Text = "*";
            // 
            // lblReqDescripcion
            // 
            this.lblReqDescripcion.AutoSize = true;
            this.lblReqDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqDescripcion.ForeColor = System.Drawing.Color.Red;
            this.lblReqDescripcion.Location = new System.Drawing.Point(10, 160);
            this.lblReqDescripcion.Name = "lblReqDescripcion";
            this.lblReqDescripcion.Size = new System.Drawing.Size(13, 16);
            this.lblReqDescripcion.TabIndex = 22;
            this.lblReqDescripcion.Text = "*";
            // 
            // lblReqPrecio
            // 
            this.lblReqPrecio.AutoSize = true;
            this.lblReqPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqPrecio.ForeColor = System.Drawing.Color.Red;
            this.lblReqPrecio.Location = new System.Drawing.Point(40, 235);
            this.lblReqPrecio.Name = "lblReqPrecio";
            this.lblReqPrecio.Size = new System.Drawing.Size(13, 16);
            this.lblReqPrecio.TabIndex = 23;
            this.lblReqPrecio.Text = "*";
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(470, 422);
            this.Controls.Add(this.lblReqPrecio);
            this.Controls.Add(this.lblReqDescripcion);
            this.Controls.Add(this.lblReqNombre);
            this.Controls.Add(this.lblReqCodigo);
            this.Controls.Add(this.txtCabeceraArticulo);
            this.Controls.Add(this.btnAnteriorImg);
            this.Controls.Add(this.btnSiguienteImg);
            this.Controls.Add(this.btnQuitarImagen);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.pbxAgregarImagen);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.MaximumSize = new System.Drawing.Size(486, 461);
            this.MinimumSize = new System.Drawing.Size(486, 461);
            this.Name = "frmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Articulo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregarImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.PictureBox pbxAgregarImagen;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.Button btnQuitarImagen;
        private System.Windows.Forms.Button btnSiguienteImg;
        private System.Windows.Forms.Button btnAnteriorImg;
        private System.Windows.Forms.Label txtCabeceraArticulo;
        private System.Windows.Forms.Label lblReqCodigo;
        private System.Windows.Forms.Label lblReqNombre;
        private System.Windows.Forms.Label lblReqDescripcion;
        private System.Windows.Forms.Label lblReqPrecio;
    }
}