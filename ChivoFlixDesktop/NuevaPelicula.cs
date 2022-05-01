using ChivoFlixDesktop.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChivoFlixDesktop
{
    public partial class NuevaPelicula : Form
    {
        public NuevaPelicula()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            PeliculaDatos peliculas = new PeliculaDatos();
            try
            {
                int anio = int.Parse(txtAnio.Text);
                string nombre = txtNombre.Text;
                string categoria = txtCEdad.Text;
                string desc = txtDesc.Text;
                string calidad = txtCalidad.Text;
                string director = txtDirector.Text;
                string banner = txtBanner.Text;
                int genero = int.Parse(txtGenero.Text);
                string pelicula = txtPelicula.Text;

                if (peliculas.InsertPelicula(anio, nombre, categoria, desc, calidad, director, banner, genero, pelicula))
                {
                    MessageBox.Show("Pelicula Ingresado");
                    Close();
                }
                else
                {
                    MessageBox.Show("Pelicula no Ingresada");
                }
            }
            catch
            {
                MessageBox.Show("Ingrese datos correctos");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
