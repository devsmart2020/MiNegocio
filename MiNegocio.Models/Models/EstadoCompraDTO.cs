using System.Collections.Generic;

namespace MiNegocio.Models.Models
{
    public class EstadoCompraDTO
    {
        public int IdEstadoCompra { get; set; }
        public string Estado { get; set; }

        public IList<CompraDTO> Tbcompra { get; set; }
    }
}
