using System.Collections.Generic;

namespace API.Domain.DTOs
{
    public class EstadoCompraDTO
    {
        public int IdEstadoCompra { get; set; }
        public string Estado { get; set; }

        public IList<CompraDTO> Tbcompra { get; set; }
    }
}
