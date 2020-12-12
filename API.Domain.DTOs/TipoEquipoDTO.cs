using System.Collections.Generic;

namespace API.Domain.DTOs
{
    public class TipoEquipoDTO
    {
        public int IdTipoEquipo { get; set; }
        public string TipoEquipo { get; set; }

        public IList<ModeloDTO> Tbmodelo { get; set; }
    }
}
