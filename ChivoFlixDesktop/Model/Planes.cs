using System;
using System.Collections.Generic;

namespace ChivoFlixDesktop.Model
{
    public partial class Planes
    {
        public int IdPlanes { get; set; }
        public string Planes1 { get; set; }
        public int IdUsuarios { get; set; }

        public virtual Usuarios IdUsuariosNavigation { get; set; }
    }
}
