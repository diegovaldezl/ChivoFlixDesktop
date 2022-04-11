using System;
using System.Collections.Generic;

namespace ChivoFlixDesktop.Model
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            Listado = new HashSet<Listado>();
            Planes = new HashSet<Planes>();
            Tarjetas = new HashSet<Tarjetas>();
        }

        public int IdUsuarios { get; set; }

        public virtual ICollection<Listado> Listado { get; set; }
        public virtual ICollection<Planes> Planes { get; set; }
        public virtual ICollection<Tarjetas> Tarjetas { get; set; }
    }
}
