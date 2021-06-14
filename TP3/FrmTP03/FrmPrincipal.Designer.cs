
namespace FrmTP03
{
    partial class FrmPrincipal
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
            this.grpAlquileres = new System.Windows.Forms.GroupBox();
            this.rtxMostrarAlquileres = new System.Windows.Forms.RichTextBox();
            this.grpControl = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMostrarVenta = new System.Windows.Forms.Button();
            this.btnIngresarVentas = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.grpAlquileres.SuspendLayout();
            this.grpControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAlquileres
            // 
            this.grpAlquileres.Controls.Add(this.rtxMostrarAlquileres);
            this.grpAlquileres.Location = new System.Drawing.Point(12, 44);
            this.grpAlquileres.Name = "grpAlquileres";
            this.grpAlquileres.Size = new System.Drawing.Size(279, 315);
            this.grpAlquileres.TabIndex = 6;
            this.grpAlquileres.TabStop = false;
            this.grpAlquileres.Text = "Alquileres";
            // 
            // rtxMostrarAlquileres
            // 
            this.rtxMostrarAlquileres.Enabled = false;
            this.rtxMostrarAlquileres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxMostrarAlquileres.Location = new System.Drawing.Point(6, 19);
            this.rtxMostrarAlquileres.Name = "rtxMostrarAlquileres";
            this.rtxMostrarAlquileres.Size = new System.Drawing.Size(267, 290);
            this.rtxMostrarAlquileres.TabIndex = 0;
            this.rtxMostrarAlquileres.Text = "";
            // 
            // grpControl
            // 
            this.grpControl.Controls.Add(this.btnQuitar);
            this.grpControl.Controls.Add(this.btnSalir);
            this.grpControl.Controls.Add(this.btnMostrarVenta);
            this.grpControl.Controls.Add(this.btnIngresarVentas);
            this.grpControl.Location = new System.Drawing.Point(297, 44);
            this.grpControl.Name = "grpControl";
            this.grpControl.Size = new System.Drawing.Size(166, 315);
            this.grpControl.TabIndex = 7;
            this.grpControl.TabStop = false;
            this.grpControl.Text = "Controles";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(6, 112);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(150, 25);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMostrarVenta
            // 
            this.btnMostrarVenta.Location = new System.Drawing.Point(6, 81);
            this.btnMostrarVenta.Name = "btnMostrarVenta";
            this.btnMostrarVenta.Size = new System.Drawing.Size(150, 25);
            this.btnMostrarVenta.TabIndex = 7;
            this.btnMostrarVenta.Text = "Actualizar lista Alquileres";
            this.btnMostrarVenta.UseVisualStyleBackColor = true;
            this.btnMostrarVenta.Click += new System.EventHandler(this.btnMostrarVenta_Click);
            // 
            // btnIngresarVentas
            // 
            this.btnIngresarVentas.Location = new System.Drawing.Point(6, 19);
            this.btnIngresarVentas.Name = "btnIngresarVentas";
            this.btnIngresarVentas.Size = new System.Drawing.Size(150, 25);
            this.btnIngresarVentas.TabIndex = 6;
            this.btnIngresarVentas.Text = "Ingresar Nuevo Alquiler";
            this.btnIngresarVentas.UseVisualStyleBackColor = true;
            this.btnIngresarVentas.Click += new System.EventHandler(this.btnIngresarVentas_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(164, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(127, 25);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Video Club";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Enabled = false;
            this.btnQuitar.Location = new System.Drawing.Point(6, 50);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(150, 25);
            this.btnQuitar.TabIndex = 9;
            this.btnQuitar.Text = "Quitar alquiler";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 372);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grpControl);
            this.Controls.Add(this.grpAlquileres);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alquileres Video Club";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.grpAlquileres.ResumeLayout(false);
            this.grpControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAlquileres;
        private System.Windows.Forms.GroupBox grpControl;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMostrarVenta;
        private System.Windows.Forms.Button btnIngresarVentas;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RichTextBox rtxMostrarAlquileres;
        private System.Windows.Forms.Button btnQuitar;
    }
}

