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
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuariosDatos usuarios = new UsuariosDatos();
            string usuario = txtUsuarioIngresar.Text;
            string email = txtEmailIngresar.Text;
            string clave = txtPasswordIngresar.Text;
            
            if(usuarios.InsertUsuario(usuario, email, clave))
            {
                MessageBox.Show("Usuario Ingresado");
            }
            else
            {
                MessageBox.Show("Usuario no Ingreado");
            }
            Close();
        }
    }
}
