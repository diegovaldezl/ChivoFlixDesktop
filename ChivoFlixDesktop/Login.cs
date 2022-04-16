using System;
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
            Ingresar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Ingresar()
        {
            string user = txtUsuario.Text;
            string clave = txtClave.Text;

            Data.ValidarLogin crud = new Data.ValidarLogin();
            if (crud.Login(user, clave))
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

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                Ingresar();
            }
        }
    }
}
