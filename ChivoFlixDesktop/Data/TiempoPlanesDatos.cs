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
    class TiempoPlanesDatos
    {
        SqlConnection cnn;
        SqlCommand cmd;
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
        public void SelectPlanesTiempo(DataGridView gvd)
        {
            try
            {
                if (ConexionBd())
                {
                    da = new SqlDataAdapter("select idDuracionPlanes as Codigo, nombre as Nombre from duracionPlanes", cnn);
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
        public bool UpdatePlanesTiempo(int id, string nombre, DataGridView dgv)
        {
            try
            {
                if (ConexionBd())
                {
                    SqlCommand cmd = new SqlCommand
                    {
                        Connection = cnn,
                        CommandType = CommandType.Text,
                        CommandText = "update duracionPlanes set nombre = '"+nombre+"' where idDuracionPlanes = "+id+"",
                    };
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    SelectPlanesTiempo(dgv);
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
        public bool DeletePlanTiempo(DataGridView dataGridView, int id)
        {
            try
            {
                if (ConexionBd())
                {
                    cmd = new SqlCommand
                    {
                        Connection = cnn,
                        CommandType = CommandType.Text,
                        CommandText = "delete duracionPlanes where idDuracionPlanes = " + id
                    };
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    SelectPlanesTiempo(dataGridView);
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
        public bool InsertPlanTiempo(string nombre)
        {
            try
            {
                if (ConexionBd())
                {
                    cmd = new SqlCommand
                    {
                        Connection = cnn,
                        CommandType = CommandType.Text,
                        CommandText = "insert into duracionPlanes(nombre) " +
                                      "values('" + nombre + "')"
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
