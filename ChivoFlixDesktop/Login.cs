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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string clave = txtClave.Text;

            MetodosCRUD crud = new MetodosCRUD();
            if (crud.login(user,clave))
            {
                Menu menu = new Menu();
                Hide();
                menu.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña invalidos");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
