using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ChivoFlixDesktop.Data
{
    class PlanesDatos
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader dr;

        public List<string> listaPlanes = new List<string>();

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
        public void SelectPlanes(DataGridView gvd)
        {
            try
            {
                if (ConexionBd())
                {
                    da = new SqlDataAdapter("select idPlanes as Id,plann as Nombre,precioPlan as Precio,duracionPlanes.nombre as 'Duracion Plan' from planes inner join duracionPlanes on planes.idUsuarios = duracionPlanes.idDuracionPlanes", cnn);
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
        public void SelectPlanes(DataGridView gvd, string plan)
        {
            try
            {
                if (ConexionBd())
                {
                    da = new SqlDataAdapter("select idPlanes as Id,plann as Nombre,precioPlan as Precio,planes.idDuracionPlanes as 'Duracion Plan' from planes inner join duracionPlanes on planes.idUsuarios = duracionPlanes.idDuracionPlanes where plann like '%" + plan + "%'", cnn);
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
        public bool UpdatePlanes(int id, string plann, double precio, DataGridView dgv)
        {
            try
            {
                if (ConexionBd())
                {
                    SqlCommand cmd = new SqlCommand
                    {
                        Connection = cnn,
                        CommandType = CommandType.Text,
                        CommandText = "update planes set plann = '" + plann + "',precioPlan='" + precio + "' where idPlanes = " + id
                    };
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    SelectPlanes(dgv);
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
        public bool DeletePlan(DataGridView dataGridView, int id)
        {
            try
            {
                if (ConexionBd())
                {
                    cmd = new SqlCommand
                    {
                        Connection = cnn,
                        CommandType = CommandType.Text,
                        CommandText = "delete planes where idPlanes = " + id
                    };
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    SelectPlanes(dataGridView);
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
        public bool InsertPlan(string plan, double precio, int duracion)
        {
            try
            {
                if (ConexionBd())
                {
                    cmd = new SqlCommand
                    {
                        Connection = cnn,
                        CommandType = CommandType.Text,
                        CommandText = "insert into planes(plann,precioPlan,idDuracionPlanes,idUsuarios) " +
                                      "values('" + plan + "','" + precio + "','" + duracion + "',1)"
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
        public void SelectPlanes()
        {
            try
            {
                if (ConexionBd())
                {
                    cmd = new SqlCommand("select idPlanes as Id,plann as Nombre,precioPlan as Precio,duracionPlanes.nombre as 'Duracion Plan' from planes inner join duracionPlanes on planes.idUsuarios = duracionPlanes.idDuracionPlanes", cnn);
                    cnn.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        listaPlanes.Add((string)dr[1]);
                        Console.Write(listaPlanes);
                    }
                    dr.Close();
                    cnn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Intente de nuevo: " + ex.ToString());
            }
        }
    }
}
