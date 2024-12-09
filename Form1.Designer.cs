namespace CoelhoGalvan
{
    partial class Form1
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
            this.buscar = new System.Windows.Forms.Button();
            this.insertar = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.listContactos = new System.Windows.Forms.ListBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(131, 118);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(136, 23);
            this.buscar.TabIndex = 0;
            this.buscar.Text = "Buscar Numero";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click_1);
            // 
            // insertar
            // 
            this.insertar.Location = new System.Drawing.Point(131, 80);
            this.insertar.Name = "insertar";
            this.insertar.Size = new System.Drawing.Size(136, 23);
            this.insertar.TabIndex = 1;
            this.insertar.Text = "Insertar contacto";
            this.insertar.UseVisualStyleBackColor = true;
            this.insertar.Click += new System.EventHandler(this.insertar_Click_1);
            // 
            // actualizar
            // 
            this.actualizar.Location = new System.Drawing.Point(131, 156);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(136, 23);
            this.actualizar.TabIndex = 2;
            this.actualizar.Text = "Actualizar contacto";
            this.actualizar.UseVisualStyleBackColor = true;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click_1);
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(131, 199);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(136, 23);
            this.eliminar.TabIndex = 3;
            this.eliminar.Text = "Eliminar contacto";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click_1);
            // 
            // listContactos
            // 
            this.listContactos.FormattingEnabled = true;
            this.listContactos.Location = new System.Drawing.Point(544, 26);
            this.listContactos.Name = "listContactos";
            this.listContactos.Size = new System.Drawing.Size(202, 355);
            this.listContactos.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNombre.Location = new System.Drawing.Point(131, 257);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(197, 20);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.Click += new System.EventHandler(this.txtNombre_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTelefono.Location = new System.Drawing.Point(131, 301);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(197, 20);
            this.txtTelefono.TabIndex = 6;
            this.txtTelefono.Text = "Telefono";
            this.txtTelefono.Click += new System.EventHandler(this.txtTelefono_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.listContactos);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.actualizar);
            this.Controls.Add(this.insertar);
            this.Controls.Add(this.buscar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button insertar;
        private System.Windows.Forms.Button actualizar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.ListBox listContactos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
    }
}

