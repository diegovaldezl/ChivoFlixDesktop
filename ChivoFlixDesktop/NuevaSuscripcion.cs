using ChivoFlixDesktop.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ChivoFlixDesktop
{
    public partial class NuevaSuscripcion : Form
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        SqlConnection cnn;
        int idSeleccionado;

        public NuevaSuscripcion()
        {
            InitializeComponent();
        }
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

        private void NuevaSuscripcion_Load(object sender, EventArgs e)
        {
            SelectPlanes();
        }
        public void SelectPlanes()
        {
            try
            {
                if (ConexionBd())
                {
                    cmd = new SqlCommand("select idPlanes as Id,plann as Nombre,precioPlan as Precio,duracionPlanes.nombre as 'Duracion Plan' from planes inner join duracionPlanes on planes.idUsuarios = duracionPlanes.idDuracionPlanes", cnn);
                    cnn.Open();
                    da = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);
                    cnn.Close();

                    DataRow fila = dt.NewRow();
                    fila["Nombre"] = "Seleccione un plan";
                    dt.Rows.InsertAt(fila, 0);
                    cbxPlan.ValueMember = "Id";
                    cbxPlan.DisplayMember = "Nombre";
                    cbxPlan.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Intente de nuevo: " + ex.ToString());
            }
        }

        public void SelectPlanesId(int id)
        {
            try
            {
                if (ConexionBd())
                {
                    cmd = new SqlCommand("select idPlanes as Id,plann as Nombre,precioPlan as Precio,duracionPlanes.nombre as 'Duracion Plan' from planes inner join duracionPlanes on planes.idUsuarios = duracionPlanes.idDuracionPlanes where planes.idPlanes = " + id, cnn);
                    cnn.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtDuracion.Text = dr["Duracion Plan"].ToString();
                        txtPrecio.Text = dr["Precio"].ToString();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Intente de nuevo: " + ex.ToString());
            }
        }

        private void cbxPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            idSeleccionado = cbxPlan.SelectedIndex;

            SelectPlanesId(cbxPlan.SelectedIndex);
        }

        private void btnSuscribirse_Click(object sender, EventArgs e)
        {
            Suscripcion suscripcion = new Suscripcion();
            string user = txtUsuario.Text;
            string pass = txtPass.Text;
            string correo = txtCorreo.Text;

            try
            {
                if (idSeleccionado == 0)
                {
                    MessageBox.Show("Seleccione un plan!");
                }
                else
                {
                    if (suscripcion.InsertUsuario(user, correo, pass, idSeleccionado))
                    {
                        MessageBox.Show("Suscripcion ingresada");
                    }
                    else
                    {
                        MessageBox.Show("Error no se puede suscribir!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ingrese datos correctos");
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}
