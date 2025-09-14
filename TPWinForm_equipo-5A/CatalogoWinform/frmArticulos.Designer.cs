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
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvArticulos.Location = new System.Drawing.Point(16, 62);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(744, 420);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(15, 489);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(124, 32);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(149, 489);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(124, 32);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminarFisicamente
            // 
            this.btnEliminarFisicamente.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarFisicamente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarFisicamente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnEliminarFisicamente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnEliminarFisicamente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarFisicamente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarFisicamente.Location = new System.Drawing.Point(284, 489);
            this.btnEliminarFisicamente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarFisicamente.Name = "btnEliminarFisicamente";
            this.btnEliminarFisicamente.Size = new System.Drawing.Size(124, 32);
            this.btnEliminarFisicamente.TabIndex = 3;
            this.btnEliminarFisicamente.Text = "Eliminar";
            this.btnEliminarFisicamente.UseVisualStyleBackColor = false;
            this.btnEliminarFisicamente.Click += new System.EventHandler(this.btnEliminarFisicamente_Click);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.Location = new System.Drawing.Point(16, 580);
            this.lblCampo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(57, 17);
            this.lblCampo.TabIndex = 3;
            this.lblCampo.Text = "Campo";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterio.Location = new System.Drawing.Point(281, 581);
            this.lblCriterio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(61, 17);
            this.lblCriterio.TabIndex = 5;
            this.lblCriterio.Text = "Criterio";
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(357, 576);
            this.cboCriterio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(160, 24);
            this.cboCriterio.TabIndex = 7;
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(77, 576);
            this.cboCampo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(160, 24);
            this.cboCampo.TabIndex = 8;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(557, 580);
            this.lblFiltroAvanzado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(45, 17);
            this.lblFiltroAvanzado.TabIndex = 9;
            this.lblFiltroAvanzado.Text = "Filtro";
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(604, 576);
            this.txtFiltroAvanzado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(132, 22);
            this.txtFiltroAvanzado.TabIndex = 10;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Location = new System.Drawing.Point(777, 574);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitulo.Location = new System.Drawing.Point(9, 11);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(224, 30);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "Listado de artículos";
            // 
            // btnVerDetalleArticulo
            // 
            this.btnVerDetalleArticulo.BackColor = System.Drawing.SystemColors.Control;
            this.btnVerDetalleArticulo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVerDetalleArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnVerDetalleArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnVerDetalleArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDetalleArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetalleArticulo.Location = new System.Drawing.Point(416, 488);
            this.btnVerDetalleArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerDetalleArticulo.Name = "btnVerDetalleArticulo";
            this.btnVerDetalleArticulo.Size = new System.Drawing.Size(124, 32);
            this.btnVerDetalleArticulo.TabIndex = 13;
            this.btnVerDetalleArticulo.Text = "Ver artículo";
            this.btnVerDetalleArticulo.UseVisualStyleBackColor = false;
            this.btnVerDetalleArticulo.Click += new System.EventHandler(this.btnVerDetalleArticulo_Click);
            // 
            // pbxImagenListado
            // 
            this.pbxImagenListado.Location = new System.Drawing.Point(904, 129);
            this.pbxImagenListado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxImagenListado.Name = "pbxImagenListado";
            this.pbxImagenListado.Size = new System.Drawing.Size(316, 257);
            this.pbxImagenListado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagenListado.TabIndex = 14;
            this.pbxImagenListado.TabStop = false;
            // 
            // btnAnteriorImg
            // 
            this.btnAnteriorImg.BackColor = System.Drawing.SystemColors.Control;
            this.btnAnteriorImg.FlatAppearance.BorderSize = 2;
            this.btnAnteriorImg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAnteriorImg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAnteriorImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnteriorImg.Location = new System.Drawing.Point(1012, 393);
            this.btnAnteriorImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnteriorImg.Name = "btnAnteriorImg";
            this.btnAnteriorImg.Size = new System.Drawing.Size(36, 30);
            this.btnAnteriorImg.TabIndex = 15;
            this.btnAnteriorImg.Text = "<";
            this.btnAnteriorImg.UseVisualStyleBackColor = false;
            this.btnAnteriorImg.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguienteImg
            // 
            this.btnSiguienteImg.BackColor = System.Drawing.SystemColors.Control;
            this.btnSiguienteImg.FlatAppearance.BorderSize = 2;
            this.btnSiguienteImg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSiguienteImg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSiguienteImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguienteImg.Location = new System.Drawing.Point(1072, 393);
            this.btnSiguienteImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSiguienteImg.Name = "btnSiguienteImg";
            this.btnSiguienteImg.Size = new System.Drawing.Size(36, 30);
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
            this.btnMenuCategorias.Location = new System.Drawing.Point(985, 471);
            this.btnMenuCategorias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMenuCategorias.Name = "btnMenuCategorias";
            this.btnMenuCategorias.Size = new System.Drawing.Size(189, 66);
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
            this.btnMenuMarcas.Location = new System.Drawing.Point(985, 545);
            this.btnMenuMarcas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMenuMarcas.Name = "btnMenuMarcas";
            this.btnMenuMarcas.Size = new System.Drawing.Size(189, 66);
            this.btnMenuMarcas.TabIndex = 20;
            this.btnMenuMarcas.Text = "Menu Marcas";
            this.btnMenuMarcas.UseVisualStyleBackColor = false;
            this.btnMenuMarcas.Click += new System.EventHandler(this.btnMenuMarcas_Click);
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1233, 620);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1251, 667);
            this.MinimumSize = new System.Drawing.Size(1251, 667);
            this.Name = "frmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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

