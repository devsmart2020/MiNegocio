using System;
using System.Collections.Generic;

namespace MiNegocio.Models.Models
{
    public class EgresoDTO
    {
        public int IdEgreso { get; set; }
        public DateTime Fecha { get; set; }
        public int FormaPago { get; set; }
        public int CtaxPagar { get; set; }
        public string IdUsuario { get; set; }
        public string Observaciones { get; set; }

        public IList<EgresoConceptoDTO> Tbegresoconcepto { get; set; }
    }
}

