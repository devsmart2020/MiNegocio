using System.Collections.Generic;

namespace API.Domain.DTOs
{
    public class ServicioDTO
    {
        public int IdServicio { get; set; }
        public string Servicio { get; set; }
        public int IdTipoServicio { get; set; }
        public int VlrServicio { get; set; }

        public TipoServicioDTO IdTipoServicioNavigation { get; set; }
        public IList<VentaServicioDTO> Tbventaservicio { get; set; }
    }
}
