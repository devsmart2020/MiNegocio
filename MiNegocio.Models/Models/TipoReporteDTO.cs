using System.Collections.Generic;

namespace MiNegocio.Models.Models
{
    public class TipoReporteDTO
    {
        public int IdTipoReporte { get; set; }
        public string Nombre { get; set; }

        public IList<ReporteDTO> Tbreportes { get; set; }
    }
}
