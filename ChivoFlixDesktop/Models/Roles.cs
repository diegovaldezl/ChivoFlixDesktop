using System;
using System.Collections.Generic;

namespace ChivoFlixDesktop.Models
{
    public partial class Roles
    {
        public Roles()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public int IdRol { get; set; }
        public string Rol { get; set; }

        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
