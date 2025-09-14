namespace CatalogoWinform
{
    partial class frmCategorias
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
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtCabeceraCategoria = new System.Windows.Forms.Label();
            this.panelCabeceraCategoria = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.panelCabeceraCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCategorias.Location = new System.Drawing.Point(112, 85);
            this.dgvCategorias.MultiSelect = false;
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(376, 189);
            this.dgvCategorias.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(112, 294);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(268, 294);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(413, 294);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtCabeceraCategoria
            // 
            this.txtCabeceraCategoria.AutoSize = true;
            this.txtCabeceraCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtCabeceraCategoria.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCabeceraCategoria.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtCabeceraCategoria.Location = new System.Drawing.Point(233, 20);
            this.txtCabeceraCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtCabeceraCategoria.Name = "txtCabeceraCategoria";
            this.txtCabeceraCategoria.Size = new System.Drawing.Size(180, 19);
            this.txtCabeceraCategoria.TabIndex = 7;
            this.txtCabeceraCategoria.Text = " GESTION DE CATEGORIAS";
            this.txtCabeceraCategoria.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelCabeceraCategoria
            // 
            this.panelCabeceraCategoria.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelCabeceraCategoria.Controls.Add(this.txtCabeceraCategoria);
            this.panelCabeceraCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabeceraCategoria.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCabeceraCategoria.Location = new System.Drawing.Point(0, 0);
            this.panelCabeceraCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCabeceraCategoria.Name = "panelCabeceraCategoria";
            this.panelCabeceraCategoria.Size = new System.Drawing.Size(600, 53);
            this.panelCabeceraCategoria.TabIndex = 9;
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panelCabeceraCategoria);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvCategorias);
            this.MaximumSize = new System.Drawing.Size(616, 405);
            this.MinimumSize = new System.Drawing.Size(616, 405);
            this.Name = "frmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.panelCabeceraCategoria.ResumeLayout(false);
            this.panelCabeceraCategoria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label txtCabeceraCategoria;
        private System.Windows.Forms.Panel panelCabeceraCategoria;
    }
}