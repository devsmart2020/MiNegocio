using System.Collections.Generic;

namespace MiNegocio.Models.Models
{
    public partial class Tbtipoproducto
    {
        public Tbtipoproducto()
        {
            Tbproducto = new HashSet<Tbproducto>();
        }

        public int IdTipoProducto { get; set; }
        public string TipoProducto { get; set; }

        public virtual ICollection<Tbproducto> Tbproducto { get; set; }
    }
}
