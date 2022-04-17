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
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;

        public bool ConexionBd()
        {
            try
            {
                cnn = new SqlConnection(Conexion.cadenaChivo);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Login(string username, string password)
        {
            bool solicitud = false;
            if (ConexionBd())
            {
                cmd = new SqlCommand
                {
                    Connection = cnn,
                    CommandType = CommandType.Text,
                    CommandText = "select * from usuarios where username = '" + username + "' and password = '" + password + "' and idRol = 1"
                };
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
