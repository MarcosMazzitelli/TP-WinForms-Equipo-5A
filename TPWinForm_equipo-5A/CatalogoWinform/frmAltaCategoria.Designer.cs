namespace CatalogoWinform
{
    partial class frmAltaCategoria
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
            this.lblDescripcionCategoria = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtDescripcionCategoria = new System.Windows.Forms.TextBox();
            this.txtCabeceraCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDescripcionCategoria
            // 
            this.lblDescripcionCategoria.AutoSize = true;
            this.lblDescripcionCategoria.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblDescripcionCategoria.Location = new System.Drawing.Point(203, 165);
            this.lblDescripcionCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionCategoria.Name = "lblDescripcionCategoria";
            this.lblDescripcionCategoria.Size = new System.Drawing.Size(107, 24);
            this.lblDescripcionCategoria.TabIndex = 0;
            this.lblDescripcionCategoria.Text = "Descripcion";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.Location = new System.Drawing.Point(246, 273);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(118, 35);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(414, 273);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 35);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtDescripcionCategoria
            // 
            this.txtDescripcionCategoria.Location = new System.Drawing.Point(318, 168);
            this.txtDescripcionCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcionCategoria.Name = "txtDescripcionCategoria";
            this.txtDescripcionCategoria.Size = new System.Drawing.Size(265, 22);
            this.txtDescripcionCategoria.TabIndex = 6;
            // 
            // txtCabeceraCategoria
            // 
            this.txtCabeceraCategoria.AutoSize = true;
            this.txtCabeceraCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtCabeceraCategoria.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Bold);
            this.txtCabeceraCategoria.ForeColor = System.Drawing.Color.Black;
            this.txtCabeceraCategoria.Location = new System.Drawing.Point(12, 20);
            this.txtCabeceraCategoria.Name = "txtCabeceraCategoria";
            this.txtCabeceraCategoria.Size = new System.Drawing.Size(235, 30);
            this.txtCabeceraCategoria.TabIndex = 7;
            this.txtCabeceraCategoria.Text = "Alta nueva categoria";
            this.txtCabeceraCategoria.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmAltaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(797, 441);
            this.Controls.Add(this.txtCabeceraCategoria);
            this.Controls.Add(this.txtDescripcionCategoria);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblDescripcionCategoria);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(815, 488);
            this.MinimumSize = new System.Drawing.Size(815, 488);
            this.Name = "frmAltaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Categoria";
            this.Load += new System.EventHandler(this.frmAltaCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcionCategoria;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtDescripcionCategoria;
        private System.Windows.Forms.Label txtCabeceraCategoria;
    }
}