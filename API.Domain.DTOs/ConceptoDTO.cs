using System.Collections.Generic;

namespace API.Domain.DTOs
{
    public class ConceptoDTO
    {
        public int IdConcepto { get; set; }
        public string Concepto { get; set; }

        public IList<ConceptoDTO> Tbegresoconcepto { get; set; }
    }
}
