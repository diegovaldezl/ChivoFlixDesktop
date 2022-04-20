using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChivoFlixDesktop.Data
{
    class UsuariosDatos
    {
        Conexion conexion = new Conexion();

        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;

        public bool conexionBd()
        {
            try
            {
                string database = "Data Source=" + conexion.servidor + ";Initial Catalog=CHIVOFLIX;Integrated Security=True";
                cnn = new SqlConnection(database);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void selectUsuarios(DataGridView gvd)
        {
            try
            {
                if (conexionBd())
                {
                    da = new SqlDataAdapter("select idUsuarios,username,email,password,perfiles,imagen,rol from usuarios inner join roles on usuarios.idRol = roles.idRol", cnn);
                    dt = new DataTable();
                    da.Fill(dt);
                    gvd.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Intente de nuevo: " + ex.ToString());
            }
        }

        public bool updateUsuario(int id,string user, string email, string clave, DataGridView dgv)
        {
            try
            {
                if (conexionBd())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update usuarios set username = '"+user+"',email='"+email+"',password = '"+clave+ "' where idRol = 1 and idUsuarios = "+id+"";
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    selectUsuarios(dgv);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Error al actualizar");
                return false;
            }
        }

        public bool InsertUsuario(string user, string email, string clave)
        {
            try
            {
                if (conexionBd())
                {
                    cmd = new SqlCommand();
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into usuarios(username,email,password,idRol) values('" + user + "','" + email + "','" + clave + "',1)";
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            
        }

        public void selectUsuarios(DataGridView gvd, string usuario)
        {
            try
            {
                if (conexionBd())
                {
                    da = new SqlDataAdapter("select idUsuarios,username,email,password,perfiles,imagen,rol from usuarios inner join roles on usuarios.idRol = roles.idRol where username like '%"+usuario+"%'", cnn);
                    dt = new DataTable();
                    da.Fill(dt);
                    gvd.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Intente de nuevo: " + ex.ToString());
            }
        }

        public bool deleteUsuario(DataGridView dataGridView, int id)
        {
            try
            {
                if (conexionBd())
                {
                    cmd = new SqlCommand();
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete usuarios where idUsuarios = "+id+"";
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    selectUsuarios(dataGridView);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
