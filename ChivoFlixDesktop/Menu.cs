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
    public partial class Menu : Form
    {
        private Form formularioActivo = null;
        public Menu()
        {
            InitializeComponent();
            subMenus();
        }

        private void subMenus()
        {
            panelUsuarios.Visible = false;
            panelPeliculas.Visible = false;
            panelCategorias.Visible = false;
            panelPlanes.Visible = false;
            panelFacturacion.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelUsuarios.Visible)
                panelUsuarios.Visible = false;
            if (panelPeliculas.Visible)
                panelPeliculas.Visible = false;
            if (panelCategorias.Visible)
                panelCategorias.Visible = false;
            if (panelPlanes.Visible)
                panelPlanes.Visible = false;
            if (panelFacturacion.Visible)
                panelFacturacion.Visible = false;
        }
        private void activeSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            activeSubMenu(panelUsuarios);
        }
        private void formularioActive(Form form)
        {
            if(formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelFormularios.Controls.Add(form);
            panelFormularios.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            activeSubMenu(panelPeliculas);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            activeSubMenu(panelCategorias);
        }


        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            activeSubMenu(panelFacturacion);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
            Login login = new Login();
            login.Show();
            
        }

        private void btnPlanes_Click(object sender, EventArgs e)
        {
            activeSubMenu(panelPlanes);
        }

        private void btnListadoUsuarios_Click(object sender, EventArgs e)
        {
            formularioActive(new ListadoUsuarios());
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            formularioActive(new NuevoUsuario());
        }

        private void btnListadoPeliculas_Click(object sender, EventArgs e)
        {
            formularioActive(new ListadoPeliculas());
        }

        private void btnNuevaPelicula_Click(object sender, EventArgs e)
        {
            formularioActive(new NuevaPelicula());
        }

        private void btnListadoCategorias_Click(object sender, EventArgs e)
        {
            formularioActive(new ListadoCategorias());
        }

        private void btnNuevaCategoria_Click(object sender, EventArgs e)
        {
            formularioActive(new NuevaCategoria());
        }

        private void btnListadoPlanes_Click(object sender, EventArgs e)
        {
            formularioActive(new ListadoPlanes());
        }

        private void btnNuevoPlan_Click(object sender, EventArgs e)
        {
            formularioActive(new NuevoPlan());
        }

        private void btnListadoFacturas_Click(object sender, EventArgs e)
        {
            formularioActive(new Facturacion());
        }

        private void panelFormularios_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
