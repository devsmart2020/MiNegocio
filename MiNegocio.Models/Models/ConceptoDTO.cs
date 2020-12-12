using System.Collections.Generic;

namespace MiNegocio.Models.Models
{
    public class ConceptoDTO
    {
        public int IdConcepto { get; set; }
        public string Concepto { get; set; }

        public IList<ConceptoDTO> Tbegresoconcepto { get; set; }
    }
}
