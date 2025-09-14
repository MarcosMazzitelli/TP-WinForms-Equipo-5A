namespace CatalogoWinform
{
    partial class frmAltaMarca
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
            this.txtDescripcionMarca = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblDescripcionCategoria = new System.Windows.Forms.Label();
            this.panelCabeceraCategoria = new System.Windows.Forms.Panel();
            this.txtCabeceraMarca = new System.Windows.Forms.Label();
            this.panelCabeceraCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescripcionMarca
            // 
            this.txtDescripcionMarca.Location = new System.Drawing.Point(293, 122);
            this.txtDescripcionMarca.Name = "txtDescripcionMarca";
            this.txtDescripcionMarca.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcionMarca.TabIndex = 10;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(326, 222);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(200, 222);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblDescripcionCategoria
            // 
            this.lblDescripcionCategoria.AutoSize = true;
            this.lblDescripcionCategoria.Location = new System.Drawing.Point(196, 125);
            this.lblDescripcionCategoria.Name = "lblDescripcionCategoria";
            this.lblDescripcionCategoria.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcionCategoria.TabIndex = 7;
            this.lblDescripcionCategoria.Text = "Descripcion";
            // 
            // panelCabeceraCategoria
            // 
            this.panelCabeceraCategoria.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelCabeceraCategoria.Controls.Add(this.txtCabeceraMarca);
            this.panelCabeceraCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabeceraCategoria.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCabeceraCategoria.Location = new System.Drawing.Point(0, 0);
            this.panelCabeceraCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCabeceraCategoria.Name = "panelCabeceraCategoria";
            this.panelCabeceraCategoria.Size = new System.Drawing.Size(600, 53);
            this.panelCabeceraCategoria.TabIndex = 11;
            // 
            // txtCabeceraMarca
            // 
            this.txtCabeceraMarca.AutoSize = true;
            this.txtCabeceraMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtCabeceraMarca.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCabeceraMarca.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtCabeceraMarca.Location = new System.Drawing.Point(26, 21);
            this.txtCabeceraMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtCabeceraMarca.Name = "txtCabeceraMarca";
            this.txtCabeceraMarca.Size = new System.Drawing.Size(142, 19);
            this.txtCabeceraMarca.TabIndex = 7;
            this.txtCabeceraMarca.Text = "ALTA NUEVA MARCA";
            this.txtCabeceraMarca.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmAltaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panelCabeceraCategoria);
            this.Controls.Add(this.txtDescripcionMarca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblDescripcionCategoria);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(616, 405);
            this.MinimumSize = new System.Drawing.Size(616, 405);
            this.Name = "frmAltaMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAltaMarca";
            this.Load += new System.EventHandler(this.frmAltaMarca_Load);
            this.panelCabeceraCategoria.ResumeLayout(false);
            this.panelCabeceraCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcionMarca;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblDescripcionCategoria;
        private System.Windows.Forms.Panel panelCabeceraCategoria;
        private System.Windows.Forms.Label txtCabeceraMarca;
    }
}