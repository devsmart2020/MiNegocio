using System.Collections.Generic;

namespace API.Domain.Entities
{
    public partial class Tbestadocompra
    {
        public Tbestadocompra()
        {
            Tbcompra = new HashSet<Tbcompra>();
        }

        public int IdEstadoCompra { get; set; }
        public string Estado { get; set; }

        public virtual ICollection<Tbcompra> Tbcompra { get; set; }
    }
}
