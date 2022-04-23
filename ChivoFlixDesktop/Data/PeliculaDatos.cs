using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ChivoFlixDesktop.Data
{
    class PeliculaDatos
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
        public void SelectPeliculas(DataGridView gvd)
        {
            try
            {
                if (ConexionBd())
                {
                    da = new SqlDataAdapter(
                        "SELECT idPeliculas as Id, peliculas.nombre as Nombre, " +
                        "anioEstreno as 'Año Estreno', categoriaEdad as Categoria, " +
                        "descripcion as Descripcion, calidad as Calidad, " +
                        "director as Director, banner as Portada, " +
                        "generos.nombre as Genero " +
                        "FROM peliculas inner join generos on " +
                        "peliculas.idGeneros = generos.idGeneros", cnn);
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
        public void SelectPeliculas(DataGridView gvd, string nombre)
        {
            try
            {
                if (ConexionBd())
                {
                    da = new SqlDataAdapter("SELECT idPeliculas as Id, peliculas.nombre as Nombre, " +
                        "anioEstreno as 'Año Estreno', categoriaEdad as Categoria, " +
                        "descripcion as Descripcion, calidad as Calidad, " +
                        "director as Director, banner as Portada, " +
                        "generos.nombre as Genero " +
                        "FROM peliculas inner join generos on " +
                        "peliculas.idGeneros = generos.idGeneros where peliculas.nombre like '%" + nombre + "%'", cnn);
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
        public bool UpdatePeliculas(int id, int anio, string nombre, string categoria, string desc, string calidad, string director, string banner, int genero, DataGridView dgv)
        {
            try
            {
                if (ConexionBd())
                {
                    SqlCommand cmd = new SqlCommand
                    {
                        Connection = cnn,
                        CommandType = CommandType.Text,
                        CommandText = "update peliculas set anioEstreno = '" + anio + "', nombre='" + nombre + "', categoriaEdad = '" + categoria + "', descripcion = '" + desc + "', calidad = '" + calidad + "', director = '" + director + "', banner = '" + banner + "', idGeneros = '" + genero + "' where idPeliculas = " + id
                    };
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    SelectPeliculas(dgv);
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
        public bool DeletePelicula(DataGridView dataGridView, int id)
        {
            try
            {
                if (ConexionBd())
                {
                    cmd = new SqlCommand
                    {
                        Connection = cnn,
                        CommandType = CommandType.Text,
                        CommandText = "delete peliculas where idPeliculas = " + id
                    };
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    SelectPeliculas(dataGridView);
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
        public bool InsertPelicula(int anio, string nombre, string categoria, string desc, string calidad, string director, string banner, int genero)
        {
            try
            {
                if (ConexionBd())
                {
                    cmd = new SqlCommand
                    {
                        Connection = cnn,
                        CommandType = CommandType.Text,
                        CommandText = "insert into peliculas(nombre,anioEstreno,categoriaEdad,descripcion,calidad,director,banner,idGeneros) " +
                        "values('" + nombre + "','" + anio + "','" + categoria + "','" + desc + "','" + calidad + "','" + director + "','" + banner + "','" + genero + "')"
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
