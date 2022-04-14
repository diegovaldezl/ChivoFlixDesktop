using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ChivoFlixDesktop.Data
{
    class ValidarLogin
    {
        Conexion conexion = new Conexion();

        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter dt;

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
        public bool login(string username, string password)
        {
            bool solicitud = false;
            if (conexionBd())
            {
                cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from usuarios where username = '"+username+"' and password = '"+password+"' and idRol = 1";
                cnn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    solicitud = true;
                }
                else
                {
                    solicitud = false;
                }
                cnn.Close();
                return solicitud;
            }
            else
            {
                return solicitud;
            }
        }
    }
}
