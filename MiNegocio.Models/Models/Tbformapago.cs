using System.Collections.Generic;

namespace MiNegocio.Models.Models
{
    public partial class Tbformapago
    {
        public Tbformapago()
        {
            Tbventa = new HashSet<Tbventa>();
            Tbventaanulada = new HashSet<Tbventaanulada>();
        }

        public int IdFormaPago { get; set; }
        public string FormaPago { get; set; }

        public virtual ICollection<Tbventa> Tbventa { get; set; }
        public virtual ICollection<Tbventaanulada> Tbventaanulada { get; set; }
    }
}
