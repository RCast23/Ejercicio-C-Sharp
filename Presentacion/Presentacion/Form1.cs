using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(new Negocio.Management.PruebaDeConexion().ProbarConexion())
            {
                lblResultado.Text = "La conexion esta flama";
            }
            else
            {
                lblResultado.Text = "Tremenda F";
            }
            lblResultado.Visible = true;
        }

        private void btnAltaLibro_Click(object sender, EventArgs e)
        {

        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminacion_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultaLibrosConUnidades_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new Negocio.Management.LibroManagement().ObtenerLibrosUnidades();
        }

        private void btnConsultaLibros_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new Negocio.Management.LibroManagement().ObtenerLibros();
        }
    }
}
