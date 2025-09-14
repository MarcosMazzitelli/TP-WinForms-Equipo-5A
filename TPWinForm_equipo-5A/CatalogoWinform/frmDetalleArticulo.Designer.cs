namespace CatalogoWinform
{
    partial class frmDetalleArticulo
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnSiguienteImg = new System.Windows.Forms.Button();
            this.btnAnteriorImg = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(7, 67);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(139, 19);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo de Artículo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCodigo.ForeColor = System.Drawing.Color.Black;
            this.txtCodigo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtCodigo.Location = new System.Drawing.Point(159, 69);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtCodigo.Size = new System.Drawing.Size(291, 22);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(359, 336);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(91, 33);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMarca.Enabled = false;
            this.txtMarca.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMarca.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtMarca.Location = new System.Drawing.Point(159, 175);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtMarca.Size = new System.Drawing.Size(291, 22);
            this.txtMarca.TabIndex = 4;
            this.txtMarca.TabStop = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDescripcion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtDescripcion.Location = new System.Drawing.Point(159, 140);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtDescripcion.Size = new System.Drawing.Size(291, 22);
            this.txtDescripcion.TabIndex = 6;
            this.txtDescripcion.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNombre.Location = new System.Drawing.Point(159, 104);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtNombre.Size = new System.Drawing.Size(291, 22);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(77, 104);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 19);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(54, 138);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(92, 19);
            this.lblDescripcion.TabIndex = 10;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(90, 176);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(56, 19);
            this.lblMarca.TabIndex = 11;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(68, 210);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(78, 19);
            this.lblCategoria.TabIndex = 12;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(90, 248);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(56, 19);
            this.lblPrecio.TabIndex = 13;
            this.lblPrecio.Text = "Precio:";
            // 
            // pbxImagen
            // 
            this.pbxImagen.Location = new System.Drawing.Point(491, 76);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(245, 254);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagen.TabIndex = 14;
            this.pbxImagen.TabStop = false;
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategoria.Enabled = false;
            this.txtCategoria.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCategoria.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtCategoria.Location = new System.Drawing.Point(159, 212);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtCategoria.Size = new System.Drawing.Size(291, 22);
            this.txtCategoria.TabIndex = 15;
            this.txtCategoria.TabStop = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPrecio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPrecio.Location = new System.Drawing.Point(159, 250);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtPrecio.Size = new System.Drawing.Size(291, 22);
            this.txtPrecio.TabIndex = 16;
            this.txtPrecio.TabStop = false;
            // 
            // btnSiguienteImg
            // 
            this.btnSiguienteImg.BackColor = System.Drawing.SystemColors.Control;
            this.btnSiguienteImg.FlatAppearance.BorderSize = 2;
            this.btnSiguienteImg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSiguienteImg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSiguienteImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguienteImg.Location = new System.Drawing.Point(631, 336);
            this.btnSiguienteImg.Name = "btnSiguienteImg";
            this.btnSiguienteImg.Size = new System.Drawing.Size(27, 24);
            this.btnSiguienteImg.TabIndex = 17;
            this.btnSiguienteImg.Text = ">";
            this.btnSiguienteImg.UseVisualStyleBackColor = false;
            this.btnSiguienteImg.Click += new System.EventHandler(this.btnSiguienteImg_Click);
            // 
            // btnAnteriorImg
            // 
            this.btnAnteriorImg.BackColor = System.Drawing.SystemColors.Control;
            this.btnAnteriorImg.FlatAppearance.BorderSize = 2;
            this.btnAnteriorImg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAnteriorImg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAnteriorImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnteriorImg.Location = new System.Drawing.Point(553, 336);
            this.btnAnteriorImg.Name = "btnAnteriorImg";
            this.btnAnteriorImg.Size = new System.Drawing.Size(27, 24);
            this.btnAnteriorImg.TabIndex = 18;
            this.btnAnteriorImg.Text = "<";
            this.btnAnteriorImg.UseVisualStyleBackColor = false;
            this.btnAnteriorImg.Click += new System.EventHandler(this.btnAnteriorImg_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitulo.Location = new System.Drawing.Point(284, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(177, 24);
            this.lblTitulo.TabIndex = 19;
            this.lblTitulo.Text = "Detalle de artículo";
            // 
            // frmDetalleArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 372);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnAnteriorImg);
            this.Controls.Add(this.btnSiguienteImg);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.MaximumSize = new System.Drawing.Size(816, 411);
            this.MinimumSize = new System.Drawing.Size(816, 411);
            this.Name = "frmDetalleArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetalleArticulo";
            this.Load += new System.EventHandler(this.frmDetalleArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnSiguienteImg;
        private System.Windows.Forms.Button btnAnteriorImg;
        private System.Windows.Forms.Label lblTitulo;
    }
}