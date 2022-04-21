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
    public partial class NuevaCategoria : Form
    {
        public NuevaCategoria()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            CategoriaDatos categoria = new CategoriaDatos();
            string nombre = txtNombre.Text;

            if (categoria.InsertCategria(nombre))
            {
                MessageBox.Show("Categoria Ingresada");
            }
            else
            {
                MessageBox.Show("Categoria no Ingreada");
            }
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
