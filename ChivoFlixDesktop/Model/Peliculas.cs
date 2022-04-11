using System;
using System.Collections.Generic;

namespace ChivoFlixDesktop.Model
{
    public partial class Peliculas
    {
        public Peliculas()
        {
            Listado = new HashSet<Listado>();
        }

        public int IdPeliculas { get; set; }
        public int AnioEstreno { get; set; }
        public string CategoriaEdad { get; set; }
        public string Descripcion { get; set; }
        public string Calidad { get; set; }
        public string Director { get; set; }
        public string Banner { get; set; }
        public int IdGeneros { get; set; }

        public virtual Generos IdGenerosNavigation { get; set; }
        public virtual ICollection<Listado> Listado { get; set; }
    }
}
