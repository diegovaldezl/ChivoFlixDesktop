using System;
using System.Collections.Generic;

namespace ChivoFlixDesktop.Model
{
    public partial class Tarjetas
    {
        public int IdTarjetas { get; set; }
        public string NumeroTarjeta { get; set; }
        public string FechaVencimiento { get; set; }
        public int Cvv { get; set; }
        public int IdUsuarios { get; set; }

        public virtual Usuarios IdUsuariosNavigation { get; set; }
    }
}
