using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ChivoFlixDesktop.Data
{
    class Suscripcion
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;

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

        public bool InsertUsuario(string user, string email, string clave, int id)
        {
            try
            {
                if (ConexionBd())
                {
                    cmd = new SqlCommand
                    {
                        Connection = cnn,
                        CommandType = CommandType.Text,
                        CommandText = "insert into usuarios(username, email, password, idRol,idPlanes)" +
                        "values('" + user + "','" + email + "','" + clave + "',2,'" + id + "')"
                    };
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
    }
}
