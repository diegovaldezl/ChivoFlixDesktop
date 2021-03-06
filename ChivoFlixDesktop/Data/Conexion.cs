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
        public static string servidor = @"localhost\SQLEXPRESS";
        private readonly List<string> roles = new List<string>() { "Administrador", "Usuario" };
        public static string cadenaChivo = "Data Source=" + servidor + ";Initial Catalog=CHIVOFLIX;Integrated Security=True";
        public bool CrearBD()
        {
            string database = "Data Source=" + servidor + ";Initial Catalog=master;Integrated Security=True";
            string squery = "CREATE DATABASE CHIVOFLIX";

            SqlConnection cnn = new SqlConnection(database);
            SqlCommand cmd = new SqlCommand(squery, cnn);

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }

        public void InsertRoles()
        {
            string cadena = "Data Source=" + servidor + ";Initial Catalog=CHIVOFLIX;Integrated Security=True";
            for(int i = 0; i < roles.Count; i++)
            {
                try
                {
                    using (SqlConnection conexion = new SqlConnection(cadena))
                    {
                        SqlCommand cmd = new SqlCommand
                        {
                            Connection = conexion,
                            CommandType = CommandType.Text,
                            CommandText = "insert into roles(rol) values('" + roles[i] + "')"
                        };
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

        public void InsertUsuario()
        {
            string cadena = "Data Source=" + servidor + ";Initial Catalog=CHIVOFLIX;Integrated Security=True";
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    SqlCommand cmd = new SqlCommand
                    {
                        Connection = conexion,
                        CommandType = CommandType.Text,
                        CommandText = "insert into usuarios(username,email,password,idRol) values('admin','admin@gmail.com','1234',1)"
                    };
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            catch
            {
                MessageBox.Show("Error al insertar el usuario");
            }
        }

    }

}
