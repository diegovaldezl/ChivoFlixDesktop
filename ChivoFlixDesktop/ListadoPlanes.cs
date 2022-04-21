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
    public partial class ListadoPlanes : Form
    {
        readonly PlanesDatos planesDatos = new PlanesDatos();
        public ListadoPlanes()
        {
            InitializeComponent();
        }

        private void ListadoUsuarios_Load(object sender, EventArgs e)
        {
            planesDatos.SelectPlanes(dvgPlanes);
        }

        public void limpiarCajas()
        {
            txtPlann.Clear();
            txtPrecio.Clear();
            txtIdPlan.Clear();
        }

        private void dvgPlanes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dvgPlanes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dvgPlanes.CurrentRow.Selected = true;
                    txtPlann.Text = dvgPlanes.Rows[e.RowIndex].Cells["plann"].FormattedValue.ToString();
                    txtPrecio.Text = dvgPlanes.Rows[e.RowIndex].Cells["precioPlan"].FormattedValue.ToString();
                    txtIdPlan.Text = dvgPlanes.Rows[e.RowIndex].Cells["idPlanes"].FormattedValue.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Seleccione una celda valida");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string plann = txtPlann.Text;
            double precio = double.Parse(txtPrecio.Text);
            int id = int.Parse(txtIdPlan.Text);
            if (planesDatos.UpdatePlanes(id, plann, precio, dvgPlanes))
            {
                MessageBox.Show("Usuario Actualizado");
            }
            else
            {
                MessageBox.Show("Error al actualizar");
            }
            limpiarCajas();
        }

        private void txtPlan_TextChanged(object sender, EventArgs e)
        {
            planesDatos.SelectPlanes(dvgPlanes, txtPlan.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdPlan.Text);
            if (planesDatos.DeletePlan(dvgPlanes, id))
            {
                limpiarCajas();
                MessageBox.Show("Usuario Eliminado");
            }
            else
            {
                MessageBox.Show("Error al eliminar el usuario");
            }
        }

        private void btnNuevoPlan_Click(object sender, EventArgs e)
        {
            NuevoPlan nuevoUsuario = new NuevoPlan();
            nuevoUsuario.ShowDialog();
            planesDatos.SelectPlanes(dvgPlanes);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {

        }
    }
}
