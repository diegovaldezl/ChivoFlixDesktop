using ChivoFlixDesktop.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace ChivoFlixDesktop
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            masterContext context = new masterContext();
            Conexion obj1 = new Conexion();
            if (context.Database.ProviderName != "Microsoft.EntityFrameworkCore.InMemory")
            {
                obj1.CrearBD();
                context.Database.Migrate();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
