using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ChivoFlixDesktop.Data
{
    class FacturacionDatos
    {
        SqlConnection cnn;
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
        public void SelectFacturaciones(DataGridView gvd)
        {
            try
            {
                if (ConexionBd())
                {
                    da = new SqlDataAdapter("select idFacturaciones,facturaciones.idUsuarios,facturaciones.idPlanes,plann,fechaAdquirido,tipo,total,usuarios.username from facturaciones  inner join usuarios on usuarios.idUsuarios = facturaciones.idFacturaciones", cnn);
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
    }
}
