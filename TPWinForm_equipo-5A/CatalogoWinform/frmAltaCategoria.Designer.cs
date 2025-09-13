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
            this.panelCabeceraCategoria = new System.Windows.Forms.Panel();
            this.panelCabeceraCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDescripcionCategoria
            // 
            this.lblDescripcionCategoria.AutoSize = true;
            this.lblDescripcionCategoria.Location = new System.Drawing.Point(120, 90);
            this.lblDescripcionCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionCategoria.Name = "lblDescripcionCategoria";
            this.lblDescripcionCategoria.Size = new System.Drawing.Size(79, 16);
            this.lblDescripcionCategoria.TabIndex = 0;
            this.lblDescripcionCategoria.Text = "Descripcion";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(124, 209);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(296, 209);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtDescripcionCategoria
            // 
            this.txtDescripcionCategoria.Location = new System.Drawing.Point(249, 86);
            this.txtDescripcionCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcionCategoria.Name = "txtDescripcionCategoria";
            this.txtDescripcionCategoria.Size = new System.Drawing.Size(132, 22);
            this.txtDescripcionCategoria.TabIndex = 6;
            // 
            // txtCabeceraCategoria
            // 
            this.txtCabeceraCategoria.AutoSize = true;
            this.txtCabeceraCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtCabeceraCategoria.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCabeceraCategoria.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtCabeceraCategoria.Location = new System.Drawing.Point(34, 26);
            this.txtCabeceraCategoria.Name = "txtCabeceraCategoria";
            this.txtCabeceraCategoria.Size = new System.Drawing.Size(203, 23);
            this.txtCabeceraCategoria.TabIndex = 7;
            this.txtCabeceraCategoria.Text = "ALTA NUEVA CATEGORIA";
            this.txtCabeceraCategoria.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelCabeceraCategoria
            // 
            this.panelCabeceraCategoria.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelCabeceraCategoria.Controls.Add(this.txtCabeceraCategoria);
            this.panelCabeceraCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabeceraCategoria.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCabeceraCategoria.Location = new System.Drawing.Point(0, 0);
            this.panelCabeceraCategoria.Name = "panelCabeceraCategoria";
            this.panelCabeceraCategoria.Size = new System.Drawing.Size(681, 65);
            this.panelCabeceraCategoria.TabIndex = 12;
            // 
            // frmAltaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 336);
            this.Controls.Add(this.panelCabeceraCategoria);
            this.Controls.Add(this.txtDescripcionCategoria);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblDescripcionCategoria);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAltaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Categoria";
            this.Load += new System.EventHandler(this.frmAltaCategoria_Load);
            this.panelCabeceraCategoria.ResumeLayout(false);
            this.panelCabeceraCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcionCategoria;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtDescripcionCategoria;
        private System.Windows.Forms.Label txtCabeceraCategoria;
        private System.Windows.Forms.Panel panelCabeceraCategoria;
    }
}