using System.Collections.Generic;

namespace MiNegocio.Models.Models
{
    public partial class Tbtipoequipo
    {
        public Tbtipoequipo()
        {
            Tbmodelo = new HashSet<Tbmodelo>();
        }

        public int IdTipoEquipo { get; set; }
        public string TipoEquipo { get; set; }

        public virtual ICollection<Tbmodelo> Tbmodelo { get; set; }
    }
}
