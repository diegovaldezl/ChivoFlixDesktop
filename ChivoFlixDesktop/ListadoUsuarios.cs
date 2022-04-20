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
    public partial class ListadoUsuarios : Form
    {
        UsuariosDatos usuariosDatos = new UsuariosDatos();
        public ListadoUsuarios()
        {
            InitializeComponent();
        }

        private void ListadoUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cHIVOFLIXDataSet.usuarios' Puede moverla o quitarla según sea necesario.
            usuariosDatos.selectUsuarios(dgvUsuarios);
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvUsuarios.CurrentRow.Selected = true;
                    txtUserName.Text = dgvUsuarios.Rows[e.RowIndex].Cells["username"].FormattedValue.ToString();
                    txtPassword.Text = dgvUsuarios.Rows[e.RowIndex].Cells["password"].FormattedValue.ToString();
                    txtEmail.Text = dgvUsuarios.Rows[e.RowIndex].Cells["email"].FormattedValue.ToString();
                    txtIdUsuario.Text = dgvUsuarios.Rows[e.RowIndex].Cells["idUsuarios"].FormattedValue.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Seleccione una celda valida");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string usuario = txtUserName.Text;
            string clave = txtPassword.Text;
            string email = txtEmail.Text;
            int id = int.Parse(txtIdUsuario.Text);
            if (usuariosDatos.updateUsuario(id,usuario, email, clave, dgvUsuarios)){
                MessageBox.Show("Usuario Actualizado");
            }
            else
            {
                MessageBox.Show("Error al actualizar");
            }
            limpiarCajas();
        }

        public void limpiarCajas()
        {
            txtEmail.Clear();
            txtPassword.Clear();
            txtUserName.Clear();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            NuevoUsuario nuevoUsuario = new NuevoUsuario();
            nuevoUsuario.ShowDialog();
            usuariosDatos.selectUsuarios(dgvUsuarios);
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            usuariosDatos.selectUsuarios(dgvUsuarios, txtUsuario.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdUsuario.Text);
            if(usuariosDatos.deleteUsuario(dgvUsuarios, id))
            {
                limpiarCajas();
                MessageBox.Show("Usuario Eliminado");
            }
            else
            {
                MessageBox.Show("Error al eliminar el usuario");
            }
        }
    }

}
