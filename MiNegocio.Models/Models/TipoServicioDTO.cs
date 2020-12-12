using System.Collections.Generic;

namespace MiNegocio.Models.Models
{
    public class TipoServicioDTO
    {
        public int IdTipoServicio { get; set; }
        public string TipoServicio { get; set; }

        public IList<ServicioDTO> Tbservicio { get; set; }
    }
}
