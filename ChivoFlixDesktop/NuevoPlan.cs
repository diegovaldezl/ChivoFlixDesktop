using ChivoFlixDesktop.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChivoFlixDesktop
{
    public partial class NuevoPlan : Form
    {
        public NuevoPlan()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            PlanesDatos planesDatos = new PlanesDatos();
            string plan = txtPlann.Text;
            double precio = double.Parse(txtPrecio.Text);
            int duracion = int.Parse(txtDuracionPlan.Text);

            if (planesDatos.InsertPlan(plan, precio, duracion))
            {
                MessageBox.Show("Plan Ingresado");
            }
            else
            {
                MessageBox.Show("Plan no Ingreado");
            }
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
