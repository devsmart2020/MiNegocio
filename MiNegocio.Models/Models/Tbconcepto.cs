using System.Collections.Generic;

namespace MiNegocio.Models.Models
{
    public partial class Tbconcepto
    {
        public Tbconcepto()
        {
            Tbegresoconcepto = new HashSet<Tbegresoconcepto>();
        }

        public int IdConcepto { get; set; }
        public string Concepto { get; set; }

        public virtual ICollection<Tbegresoconcepto> Tbegresoconcepto { get; set; }
    }
}
