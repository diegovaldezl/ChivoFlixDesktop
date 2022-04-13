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
        public string servidor = "DESKTOP-SNEK398";
        private List<string> roles = new List<string>() { "Administrador", "Usuario" };
        public void CrearBD()
        {
            string database = "Data Source="+servidor+";Initial Catalog=master;Integrated Security=True";
            //string database = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=master; Integrated Security=True;";
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

        public void insertRoles()
        {
            string cadena = "Data Source=" + servidor + ";Initial Catalog=CHIVOFLIX;Integrated Security=True";
            for(int i = 0; i < roles.Count; i++)
            {
                try
                {
                    using (SqlConnection conexion = new SqlConnection(cadena))
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into roles(rol) values('" + roles[i] + "')";
                        conexion.Open();
                        cmd.ExecuteNonQuery();
                        conexion.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Error al ingresar los roles");
                }
            }
        }
    }

}
