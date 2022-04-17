using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChivoFlixDesktop
{
    public partial class ListadoUsuarios : Form
    {


        public ListadoUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from usuarios",con);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = cmd;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                gvListaUsuarios.DataSource = tabla;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(Conexion.cadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from usuarios where idUsuarios =@ID", con);
                cmd.Parameters.AddWithValue("@ID", txt_ID.Text);

                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.Read())
                {
                    txt_User.Text = registro["username"].ToString();
                    txt_Email.Text = registro["email"].ToString();
                }
            }


        }

        private void gvListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = gvListaUsuarios.SelectedCells[0].Value.ToString();
            txt_User.Text = gvListaUsuarios.SelectedCells[1].Value.ToString();
            txt_Email.Text = gvListaUsuarios.SelectedCells[2].Value.ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_ID.Clear();
            txt_User.Clear();
            txt_Email.Clear();
        }
    }
}
