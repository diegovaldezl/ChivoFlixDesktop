using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChivoFlixDesktop.Data;

namespace ChivoFlixDesktop
{
    public partial class ListadoUsuarios : Form
    {
        public ListadoUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            using (SqlConnection con = new SqlConnection(Conexion.database)) ;
            SqlCommand commando = new SqlCommand("Select * from usuarios",  );
        }
    }
}
