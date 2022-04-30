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
    public partial class PlanTiempo : Form
    {
        TiempoPlanesDatos tiempoPlanesDatos = new TiempoPlanesDatos();
        private String idTiempo;
        public PlanTiempo()
        {
            InitializeComponent();
        }

        private void PlanTiempo_Load(object sender, EventArgs e)
        {
            tiempoPlanesDatos.SelectPlanesTiempo(dgvTiempo);
        }

        private void btnAgregarTiempo_Click(object sender, EventArgs e)
        {
            if(txtNombreTiempo.Text == "")
            {
                MessageBox.Show("El campo no puede estar vacío");
            }
            else
            {
                if (tiempoPlanesDatos.InsertPlanTiempo(txtNombreTiempo.Text))
                {
                    tiempoPlanesDatos.SelectPlanesTiempo(dgvTiempo);
                    MessageBox.Show("Registro Ingresado");
                    txtNombreTiempo.Clear();
                }
                else
                {
                    MessageBox.Show("Error al ingresar");
                }
            }
        }

        private void btnModificarTiempo_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(idTiempo);
                if(tiempoPlanesDatos.UpdatePlanesTiempo(codigo, txtNombreTiempo.Text, dgvTiempo))
                {
                    MessageBox.Show("Dato Modificado");
                    txtNombreTiempo.Clear();
                }
                else
                {
                    MessageBox.Show("Error al modificar");
                }
            }
            catch
            {
                MessageBox.Show("Intente de nuevo");
            }
        }

        private void btnEliminarTiempo_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(idTiempo);
                if (tiempoPlanesDatos.DeletePlanTiempo(dgvTiempo, codigo))
                {
                    MessageBox.Show("Registro eliminado");
                    txtNombreTiempo.Clear();
                }
                else
                {
                    MessageBox.Show("Error al eliminar");
                }
            }
            catch
            {
                MessageBox.Show("Intente de nuevo");
            }
        }

        private void dgvTiempo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvTiempo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvTiempo.CurrentRow.Selected = true;
                    txtNombreTiempo.Text = dgvTiempo.Rows[e.RowIndex].Cells["Nombre"].FormattedValue.ToString();
                    idTiempo = dgvTiempo.Rows[e.RowIndex].Cells["Codigo"].FormattedValue.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Seleccione una celda valida");
            }
        }
    }
}
