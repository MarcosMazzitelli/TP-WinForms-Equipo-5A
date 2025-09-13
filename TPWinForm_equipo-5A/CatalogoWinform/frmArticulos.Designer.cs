namespace CatalogoWinform
{
    partial class frmArticulos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarFisicamente = new System.Windows.Forms.Button();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnVerDetalleArticulo = new System.Windows.Forms.Button();
            this.pbxImagenListado = new System.Windows.Forms.PictureBox();
            this.btnAnteriorImg = new System.Windows.Forms.Button();
            this.btnSiguienteImg = new System.Windows.Forms.Button();
            this.btnMenuCategorias = new System.Windows.Forms.Button();
            this.btnMenuMarcas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenListado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 67);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(595, 324);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.FlatAppearance.BorderSize = 2;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(11, 397);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(93, 26);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificar.FlatAppearance.BorderSize = 2;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(112, 397);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(93, 26);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminarFisicamente
            // 
            this.btnEliminarFisicamente.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarFisicamente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarFisicamente.FlatAppearance.BorderSize = 2;
            this.btnEliminarFisicamente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnEliminarFisicamente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarFisicamente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarFisicamente.Location = new System.Drawing.Point(213, 397);
            this.btnEliminarFisicamente.Name = "btnEliminarFisicamente";
            this.btnEliminarFisicamente.Size = new System.Drawing.Size(93, 26);
            this.btnEliminarFisicamente.TabIndex = 3;
            this.btnEliminarFisicamente.Text = "Eliminar";
            this.btnEliminarFisicamente.UseVisualStyleBackColor = false;
            this.btnEliminarFisicamente.Click += new System.EventHandler(this.btnEliminarFisicamente_Click);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.Location = new System.Drawing.Point(12, 471);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(45, 13);
            this.lblCampo.TabIndex = 3;
            this.lblCampo.Text = "Campo";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterio.Location = new System.Drawing.Point(211, 472);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(47, 13);
            this.lblCriterio.TabIndex = 5;
            this.lblCriterio.Text = "Criterio";
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(268, 468);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(121, 21);
            this.cboCriterio.TabIndex = 7;
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(58, 468);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(121, 21);
            this.cboCampo.TabIndex = 8;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(418, 471);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(35, 13);
            this.lblFiltroAvanzado.TabIndex = 9;
            this.lblFiltroAvanzado.Text = "Filtro";
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(453, 468);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroAvanzado.TabIndex = 10;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatAppearance.BorderSize = 2;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Location = new System.Drawing.Point(583, 466);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe MDL2 Assets", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitulo.Location = new System.Drawing.Point(104, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(392, 46);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "Listado de artículos";
            // 
            // btnVerDetalleArticulo
            // 
            this.btnVerDetalleArticulo.BackColor = System.Drawing.SystemColors.Control;
            this.btnVerDetalleArticulo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVerDetalleArticulo.FlatAppearance.BorderSize = 2;
            this.btnVerDetalleArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnVerDetalleArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDetalleArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetalleArticulo.Location = new System.Drawing.Point(441, 397);
            this.btnVerDetalleArticulo.Name = "btnVerDetalleArticulo";
            this.btnVerDetalleArticulo.Size = new System.Drawing.Size(112, 40);
            this.btnVerDetalleArticulo.TabIndex = 13;
            this.btnVerDetalleArticulo.Text = "Ver artículo";
            this.btnVerDetalleArticulo.UseVisualStyleBackColor = false;
            this.btnVerDetalleArticulo.Click += new System.EventHandler(this.btnVerDetalleArticulo_Click);
            // 
            // pbxImagenListado
            // 
            this.pbxImagenListado.Location = new System.Drawing.Point(678, 105);
            this.pbxImagenListado.Name = "pbxImagenListado";
            this.pbxImagenListado.Size = new System.Drawing.Size(237, 209);
            this.pbxImagenListado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagenListado.TabIndex = 14;
            this.pbxImagenListado.TabStop = false;
            // 
            // btnAnteriorImg
            // 
            this.btnAnteriorImg.BackColor = System.Drawing.SystemColors.Control;
            this.btnAnteriorImg.FlatAppearance.BorderSize = 2;
            this.btnAnteriorImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnteriorImg.Location = new System.Drawing.Point(759, 319);
            this.btnAnteriorImg.Name = "btnAnteriorImg";
            this.btnAnteriorImg.Size = new System.Drawing.Size(27, 24);
            this.btnAnteriorImg.TabIndex = 15;
            this.btnAnteriorImg.Text = "<";
            this.btnAnteriorImg.UseVisualStyleBackColor = false;
            this.btnAnteriorImg.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguienteImg
            // 
            this.btnSiguienteImg.BackColor = System.Drawing.SystemColors.Control;
            this.btnSiguienteImg.FlatAppearance.BorderSize = 2;
            this.btnSiguienteImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguienteImg.Location = new System.Drawing.Point(804, 319);
            this.btnSiguienteImg.Name = "btnSiguienteImg";
            this.btnSiguienteImg.Size = new System.Drawing.Size(27, 24);
            this.btnSiguienteImg.TabIndex = 17;
            this.btnSiguienteImg.Text = ">";
            this.btnSiguienteImg.UseVisualStyleBackColor = false;
            this.btnSiguienteImg.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnMenuCategorias
            // 
            this.btnMenuCategorias.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenuCategorias.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMenuCategorias.FlatAppearance.BorderSize = 2;
            this.btnMenuCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMenuCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCategorias.Location = new System.Drawing.Point(739, 383);
            this.btnMenuCategorias.Name = "btnMenuCategorias";
            this.btnMenuCategorias.Size = new System.Drawing.Size(142, 54);
            this.btnMenuCategorias.TabIndex = 19;
            this.btnMenuCategorias.Text = "Menu Categorías";
            this.btnMenuCategorias.UseVisualStyleBackColor = false;
            this.btnMenuCategorias.Click += new System.EventHandler(this.btnMenuCategorias_Click);
            // 
            // btnMenuMarcas
            // 
            this.btnMenuMarcas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenuMarcas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMenuMarcas.FlatAppearance.BorderSize = 2;
            this.btnMenuMarcas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMenuMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuMarcas.Location = new System.Drawing.Point(739, 443);
            this.btnMenuMarcas.Name = "btnMenuMarcas";
            this.btnMenuMarcas.Size = new System.Drawing.Size(142, 54);
            this.btnMenuMarcas.TabIndex = 20;
            this.btnMenuMarcas.Text = "Menu Marcas";
            this.btnMenuMarcas.UseVisualStyleBackColor = false;
            this.btnMenuMarcas.Click += new System.EventHandler(this.btnMenuMarcas_Click);
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(927, 512);
            this.Controls.Add(this.btnMenuMarcas);
            this.Controls.Add(this.btnMenuCategorias);
            this.Controls.Add(this.btnSiguienteImg);
            this.Controls.Add(this.btnAnteriorImg);
            this.Controls.Add(this.pbxImagenListado);
            this.Controls.Add(this.btnVerDetalleArticulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnEliminarFisicamente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtFiltroAvanzado);
            this.Controls.Add(this.lblFiltroAvanzado);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvArticulos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmArticulos";
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarFisicamente;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnVerDetalleArticulo;
        private System.Windows.Forms.PictureBox pbxImagenListado;
        private System.Windows.Forms.Button btnAnteriorImg;
        private System.Windows.Forms.Button btnSiguienteImg;
        private System.Windows.Forms.Button btnMenuCategorias;
        private System.Windows.Forms.Button btnMenuMarcas;
    }
}

