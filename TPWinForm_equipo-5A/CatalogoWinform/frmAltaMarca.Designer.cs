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
            this.txtDescripcionMarca.Location = new System.Drawing.Point(391, 150);
            this.txtDescripcionMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcionMarca.Name = "txtDescripcionMarca";
            this.txtDescripcionMarca.Size = new System.Drawing.Size(132, 22);
            this.txtDescripcionMarca.TabIndex = 10;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(434, 273);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(266, 273);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblDescripcionCategoria
            // 
            this.lblDescripcionCategoria.AutoSize = true;
            this.lblDescripcionCategoria.Location = new System.Drawing.Point(262, 154);
            this.lblDescripcionCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionCategoria.Name = "lblDescripcionCategoria";
            this.lblDescripcionCategoria.Size = new System.Drawing.Size(79, 16);
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
            this.panelCabeceraCategoria.Name = "panelCabeceraCategoria";
            this.panelCabeceraCategoria.Size = new System.Drawing.Size(800, 65);
            this.panelCabeceraCategoria.TabIndex = 11;
            // 
            // txtCabeceraMarca
            // 
            this.txtCabeceraMarca.AutoSize = true;
            this.txtCabeceraMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtCabeceraMarca.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCabeceraMarca.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtCabeceraMarca.Location = new System.Drawing.Point(34, 26);
            this.txtCabeceraMarca.Name = "txtCabeceraMarca";
            this.txtCabeceraMarca.Size = new System.Drawing.Size(172, 23);
            this.txtCabeceraMarca.TabIndex = 7;
            this.txtCabeceraMarca.Text = "ALTA NUEVA MARCA";
            this.txtCabeceraMarca.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmAltaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCabeceraCategoria);
            this.Controls.Add(this.txtDescripcionMarca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblDescripcionCategoria);
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