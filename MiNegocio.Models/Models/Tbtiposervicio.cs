using System.Collections.Generic;

namespace MiNegocio.Models.Models
{
    public partial class Tbtiposervicio
    {
        public Tbtiposervicio()
        {
            Tbservicio = new HashSet<Tbservicio>();
        }

        public int IdTipoServicio { get; set; }
        public string TipoServicio { get; set; }

        public virtual ICollection<Tbservicio> Tbservicio { get; set; }
    }
}
