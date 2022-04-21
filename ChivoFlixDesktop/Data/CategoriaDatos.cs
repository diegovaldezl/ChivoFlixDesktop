using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ChivoFlixDesktop.Data
{
    class CategoriaDatos
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
        public void SelectCategorias(DataGridView gvd)
        {
            try
            {
                if (ConexionBd())
                {
                    da = new SqlDataAdapter("select * from generos", cnn);
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
        public void SelectCategorias(DataGridView gvd, string nombre)
        {
            try
            {
                if (ConexionBd())
                {
                    da = new SqlDataAdapter("select * from generos where nombre like '%" + nombre + "%'", cnn);
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
        public bool UpdateCategorias(int id, string nombre, DataGridView dgv)
        {
            try
            {
                if (ConexionBd())
                {
                    SqlCommand cmd = new SqlCommand
                    {
                        Connection = cnn,
                        CommandType = CommandType.Text,
                        CommandText = "update generos set nombre = '" + nombre + "' where idGeneros = " + id
                    };
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    SelectCategorias(dgv);
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
        public bool DeleteCategoria(DataGridView dataGridView, int id)
        {
            try
            {
                if (ConexionBd())
                {
                    cmd = new SqlCommand
                    {
                        Connection = cnn,
                        CommandType = CommandType.Text,
                        CommandText = "delete generos where idGeneros = " + id
                    };
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    SelectCategorias(dataGridView);
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
        public bool InsertCategria(string nombre)
        {
            try
            {
                if (ConexionBd())
                {
                    cmd = new SqlCommand
                    {
                        Connection = cnn,
                        CommandType = CommandType.Text,
                        CommandText = "insert into generos(nombre) values('" + nombre + "')"
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
