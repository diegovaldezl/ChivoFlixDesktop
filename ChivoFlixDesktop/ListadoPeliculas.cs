using ChivoFlixDesktop.Data;
using ChivoFlixDesktop.Reportes;
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
    public partial class ListadoPeliculas : Form
    {
        PeliculaDatos peliculaDatos = new PeliculaDatos();
        public ListadoPeliculas()
        {
            InitializeComponent();
        }
        private void ListadoPeliculas_Load(object sender, EventArgs e)
        {
            peliculaDatos.SelectPeliculas(dgvPeliculas);
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            NuevaPelicula nuevaPelicula = new NuevaPelicula();
            nuevaPelicula.ShowDialog();
            peliculaDatos.SelectPeliculas(dgvPeliculas);
        }
        private void dgvPeliculas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPeliculas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvPeliculas.CurrentRow.Selected = true;
                    txtAnio.Text = dgvPeliculas.Rows[e.RowIndex].Cells["Año Estreno"].FormattedValue.ToString();
                    txtBanner.Text = dgvPeliculas.Rows[e.RowIndex].Cells["Portada"].FormattedValue.ToString();
                    txtCalidad.Text = dgvPeliculas.Rows[e.RowIndex].Cells["Calidad"].FormattedValue.ToString();
                    txtDescripcion.Text = dgvPeliculas.Rows[e.RowIndex].Cells["Descripcion"].FormattedValue.ToString();
                    txtDirector.Text = dgvPeliculas.Rows[e.RowIndex].Cells["Director"].FormattedValue.ToString();
                    txtEdad.Text = dgvPeliculas.Rows[e.RowIndex].Cells["Categoria"].FormattedValue.ToString();
                    txtIdPelicula.Text = dgvPeliculas.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                    txtNombre.Text = dgvPeliculas.Rows[e.RowIndex].Cells["Nombre"].FormattedValue.ToString();
                    txtGenero.Text = dgvPeliculas.Rows[e.RowIndex].Cells["Genero"].FormattedValue.ToString();
                    txtPelicula.Text = dgvPeliculas.Rows[e.RowIndex].Cells["Pelicula"].FormattedValue.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Seleccione una celda valida");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtIdPelicula.Text);
                int anio = int.Parse(txtAnio.Text);
                string nombre = txtNombre.Text;
                string categoria = txtEdad.Text;
                string desc = txtDescripcion.Text;
                string calidad = txtCalidad.Text;
                string director = txtDirector.Text;
                string banner = txtBanner.Text;
                string link = txtPelicula.Text;

                int genero = int.Parse(txtGenero.Text);
                if (peliculaDatos.UpdatePeliculas(id, anio, nombre, categoria, desc, calidad, director, banner, genero, link, dgvPeliculas))
                {
                    MessageBox.Show("Pelicula Actualizada");
                    LimpiarCajas();
                }
                else
                {
                    MessageBox.Show("Error al actualizar");
                }
            }
            catch
            {
                MessageBox.Show("Error, el genero tiene que ser por ID");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdPelicula.Text);
            if (peliculaDatos.DeletePelicula(dgvPeliculas, id))
            {
                LimpiarCajas();
                MessageBox.Show("Pelicula Eliminada");
            }
            else
            {
                MessageBox.Show("Error al eliminar la pelicula");
            }
        }
        public void LimpiarCajas()
        {
            txtIdPelicula.Clear();
            txtAnio.Clear();
            txtBanner.Clear();
            txtCalidad.Clear();
            txtDescripcion.Clear();
            txtDirector.Clear();
            txtEdad.Clear();
            txtNombre.Clear();
            txtGenero.Clear();
            txtPelicula.Clear();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            peliculaDatos.SelectPeliculas(dgvPeliculas, txtBuscar.Text);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Reportes.ReportePeliculas reporte = new Reportes.ReportePeliculas();
            reporte.ShowDialog();
        }
    }
}
