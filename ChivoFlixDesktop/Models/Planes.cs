using System;
using System.Collections.Generic;

namespace ChivoFlixDesktop.Models
{
    public partial class Planes
    {
        public Planes()
        {
            Facturaciones = new HashSet<Facturaciones>();
        }

        public int IdPlanes { get; set; }
        public string Plann { get; set; }
        public double PrecioPlan { get; set; }
        public int IdDuracionPlanes { get; set; }
        public int IdUsuarios { get; set; }

        public virtual DuracionPlanes IdDuracionPlanesNavigation { get; set; }
        public virtual Usuarios IdUsuariosNavigation { get; set; }
        public virtual ICollection<Facturaciones> Facturaciones { get; set; }
    }
}
