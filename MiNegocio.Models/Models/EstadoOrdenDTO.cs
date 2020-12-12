using System.Collections.Generic;

namespace MiNegocio.Models.Models
{
    public class EstadoOrdenDTO
    {
        public int IdEstadoOrden { get; set; }
        public string EstadoOrden { get; set; }

        public IList<OrdenDTO> Tborden { get; set; }
    }
}
