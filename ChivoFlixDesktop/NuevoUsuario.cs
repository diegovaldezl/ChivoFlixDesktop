using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChivoFlixDesktop.Data;

namespace ChivoFlixDesktop
{
    public partial class NuevoUsuario : Form
    {

        public byte[] buffer;
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadenaConexion))
            {
                con.Open();

                try
                {
                    string query = "Insert into usuarios (username, email, password) values (@user,@mail,@pass)";
                    SqlCommand cmd = new SqlCommand(query,con);
                    cmd.Parameters.AddWithValue("@user", txt_userName.Text);
                    cmd.Parameters.AddWithValue("@mail", txt_Email.Text);
                    cmd.Parameters.AddWithValue("@pass", txt_pass.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Insertado con exito");

                }
                catch
                {
                    MessageBox.Show("Verifique todos los campos");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombrearchivo = "";

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "All Bitmap files|*.bmp;*.jpg;*.jpeg;*.png";

            ofd.Title = "Open a Bitmap File";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                nombrearchivo = ofd.FileName;

                FileStream fs;

                fs = new FileStream(nombrearchivo, FileMode.Open);

                FileInfo fi;

                fi = new FileInfo(nombrearchivo);

                long longitud;

                longitud = fi.Length;

                //byte []buffer = new byte[longitud];

                buffer = new byte[longitud];

                fs.Read(buffer, 0, Convert.ToInt32(longitud));

                fs.Close();

                Bitmap imagen = new Bitmap(new MemoryStream(buffer));

                foto.Image = imagen;
            }
        }
    }
}
