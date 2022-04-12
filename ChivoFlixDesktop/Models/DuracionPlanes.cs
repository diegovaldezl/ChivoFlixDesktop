using System;
using System.Collections.Generic;

namespace ChivoFlixDesktop.Models
{
    public partial class DuracionPlanes
    {
        public DuracionPlanes()
        {
            Planes = new HashSet<Planes>();
        }

        public int IdDuracionPlanes { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Planes> Planes { get; set; }
    }
}
