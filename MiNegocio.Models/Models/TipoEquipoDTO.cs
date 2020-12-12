using System.Collections.Generic;

namespace MiNegocio.Models.Models
{
    public class TipoEquipoDTO
    {
        public int IdTipoEquipo { get; set; }
        public string TipoEquipo { get; set; }

        public IList<ModeloDTO> Tbmodelo { get; set; }
    }
}
