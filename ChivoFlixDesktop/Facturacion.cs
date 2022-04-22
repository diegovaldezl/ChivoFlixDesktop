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
    public partial class Facturacion : Form
    {
        FacturacionDatos facturacion = new FacturacionDatos();
        public Facturacion()
        {
            InitializeComponent();
        }
        private void ListadoFacturaciones_Load(object sender, EventArgs e)
        {
            facturacion.SelectFacturaciones(dgvFacturacion);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Reportes.ReporteCategorias reporte = new Reportes.ReporteCategorias();
            reporte.ShowDialog();
        }
    }
}
