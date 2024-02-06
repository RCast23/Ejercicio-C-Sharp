using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.Views;

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
                lblResultado.Text = "Conexion correcta";
            }
            else
            {
                lblResultado.Text = "Error de conexion";
            }
            lblResultado.Visible = true;
        }

        private void btnAltaLibro_Click(object sender, EventArgs e)
        {
            AltaLibro pantallaAlta = new AltaLibro();
            pantallaAlta.ShowDialog();
            dataGridView1.DataSource = new Negocio.Management.LibroManagement().ObtenerLibros();
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Negocio.EntitiesDTO.LibrosDTO libroSeleccionado = dataGridView1.CurrentRow.DataBoundItem as Negocio.EntitiesDTO.LibrosDTO;
                AltaLibro pantallaAlta = new AltaLibro(libroSeleccionado);
                pantallaAlta.ShowDialog();
                dataGridView1.DataSource = new Negocio.Management.LibroManagement().ObtenerLibros();
            }
        }

        private void btnEliminacion_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Negocio.EntitiesDTO.LibrosDTO libroSeleccionado = dataGridView1.CurrentRow.DataBoundItem as Negocio.EntitiesDTO.LibrosDTO;
                if (new Negocio.Management.LibroManagement().VerificarUnidades(libroSeleccionado.idLibro))
                {
                    DialogResult respuesta = MessageBox.Show("Este libro contiene unidades" + System.Environment.NewLine + "¿Esta seguro de querer eliminarlo?", "Validacion", MessageBoxButtons.YesNo);
                    if (respuesta == DialogResult.Yes)
                    {
                        new Negocio.Management.LibroManagement().EliminarLibro(libroSeleccionado);
                    }
                }
                else
                {
                    new Negocio.Management.LibroManagement().EliminarLibro(libroSeleccionado);
                }
                dataGridView1.DataSource = new Negocio.Management.LibroManagement().ObtenerLibros();
            }
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
