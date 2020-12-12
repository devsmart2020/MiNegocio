using System.Collections.Generic;

namespace API.Domain.DTOs
{
    public class FormaPagoDTO
    {
        public int IdFormaPago { get; set; }
        public string FormaPago { get; set; }

        public IList<VentaDTO> Tbventa { get; set; }
        public IList<VentaAnuladaDTO> Tbventaanulada { get; set; }
    }
}
