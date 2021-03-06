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
    public partial class ListadoCategorias : Form
    {
        readonly CategoriaDatos categoriaDatos = new CategoriaDatos();
        public ListadoCategorias()
        {
            InitializeComponent();
        }
        private void ListadoCategorias_Load(object sender, EventArgs e)
        {
            categoriaDatos.SelectCategorias(dgvCategorias);
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCategorias.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvCategorias.CurrentRow.Selected = true;
                    txtNombre.Text = dgvCategorias.Rows[e.RowIndex].Cells["Nombre"].FormattedValue.ToString();
                    txtId.Text = dgvCategorias.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Seleccione una celda valida");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevaCategoria nuevaCategoria = new NuevaCategoria();
            nuevaCategoria.ShowDialog();
            categoriaDatos.SelectCategorias(dgvCategorias);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int id = int.Parse(txtId.Text);
            if (categoriaDatos.UpdateCategorias(id, nombre, dgvCategorias))
            {
                MessageBox.Show("Categoria Actualizada");
            }
            else
            {
                MessageBox.Show("Error al actualizar");
            }
            limpiarCajas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            if (categoriaDatos.DeleteCategoria(dgvCategorias, id))
            {
                limpiarCajas();
                MessageBox.Show("Categoria Eliminada");
            }
            else
            {
                MessageBox.Show("Error al eliminar el categoria");
            }
        }
        public void limpiarCajas()
        {
            txtNombre.Clear();
            txtId.Clear();
        }

        private void txtNombreBuscar_TextChanged(object sender, EventArgs e)
        {
            categoriaDatos.SelectCategorias(dgvCategorias, txtNombreBuscar.Text);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Reportes.ReporteCategorias reporte = new Reportes.ReporteCategorias();
            reporte.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
