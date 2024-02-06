namespace Presentacion
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
            this.btnPrueba = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnAltaLibro = new System.Windows.Forms.Button();
            this.btnModificacion = new System.Windows.Forms.Button();
            this.btnEliminacion = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConsultaLibros = new System.Windows.Forms.Button();
            this.btnConsultaLibrosConUnidades = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(12, 76);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(181, 78);
            this.btnPrueba.TabIndex = 0;
            this.btnPrueba.Text = "Prueba de conexion";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(74, 224);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(44, 16);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "label1";
            this.lblResultado.Visible = false;
            // 
            // btnAltaLibro
            // 
            this.btnAltaLibro.Location = new System.Drawing.Point(256, 76);
            this.btnAltaLibro.Name = "btnAltaLibro";
            this.btnAltaLibro.Size = new System.Drawing.Size(167, 78);
            this.btnAltaLibro.TabIndex = 2;
            this.btnAltaLibro.Text = "Alta de Libro";
            this.btnAltaLibro.UseVisualStyleBackColor = true;
            this.btnAltaLibro.Click += new System.EventHandler(this.btnAltaLibro_Click);
            // 
            // btnModificacion
            // 
            this.btnModificacion.Location = new System.Drawing.Point(449, 76);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(167, 78);
            this.btnModificacion.TabIndex = 3;
            this.btnModificacion.Text = "Modificacion de Libro";
            this.btnModificacion.UseVisualStyleBackColor = true;
            this.btnModificacion.Click += new System.EventHandler(this.btnModificacion_Click);
            // 
            // btnEliminacion
            // 
            this.btnEliminacion.Location = new System.Drawing.Point(351, 162);
            this.btnEliminacion.Name = "btnEliminacion";
            this.btnEliminacion.Size = new System.Drawing.Size(167, 78);
            this.btnEliminacion.TabIndex = 4;
            this.btnEliminacion.Text = "Eliminar Libro";
            this.btnEliminacion.UseVisualStyleBackColor = true;
            this.btnEliminacion.Click += new System.EventHandler(this.btnEliminacion_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(798, 191);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnConsultaLibros
            // 
            this.btnConsultaLibros.Location = new System.Drawing.Point(632, 76);
            this.btnConsultaLibros.Name = "btnConsultaLibros";
            this.btnConsultaLibros.Size = new System.Drawing.Size(167, 78);
            this.btnConsultaLibros.TabIndex = 6;
            this.btnConsultaLibros.Text = "Consulta de Libros";
            this.btnConsultaLibros.UseVisualStyleBackColor = true;
            this.btnConsultaLibros.Click += new System.EventHandler(this.btnConsultaLibros_Click);
            // 
            // btnConsultaLibrosConUnidades
            // 
            this.btnConsultaLibrosConUnidades.Location = new System.Drawing.Point(632, 162);
            this.btnConsultaLibrosConUnidades.Name = "btnConsultaLibrosConUnidades";
            this.btnConsultaLibrosConUnidades.Size = new System.Drawing.Size(167, 78);
            this.btnConsultaLibrosConUnidades.TabIndex = 7;
            this.btnConsultaLibrosConUnidades.Text = "Consulta de Libros con Unidades";
            this.btnConsultaLibrosConUnidades.UseVisualStyleBackColor = true;
            this.btnConsultaLibrosConUnidades.Click += new System.EventHandler(this.btnConsultaLibrosConUnidades_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConsultaLibrosConUnidades);
            this.Controls.Add(this.btnConsultaLibros);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEliminacion);
            this.Controls.Add(this.btnModificacion);
            this.Controls.Add(this.btnAltaLibro);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnPrueba);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnAltaLibro;
        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.Button btnEliminacion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConsultaLibros;
        private System.Windows.Forms.Button btnConsultaLibrosConUnidades;
    }
}

