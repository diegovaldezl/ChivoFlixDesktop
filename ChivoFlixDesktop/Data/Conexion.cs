using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChivoFlixDesktop
{
    public class Conexion
    {
        public void CrearBD()
        {
            string database = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=master; Integrated Security=True;";
            string squery = "CREATE DATABASE CHIVOFLIX";

            SqlConnection cnn = new SqlConnection(database);
            SqlCommand cmd = new SqlCommand(squery, cnn);

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al crear la base chivoflix", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }
    }
}
