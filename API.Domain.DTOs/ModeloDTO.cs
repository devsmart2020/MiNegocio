using System.Collections.Generic;

namespace API.Domain.DTOs
{
    public class ModeloDTO
    {
        public int IdModelo { get; set; }
        public string Modelo { get; set; }
        public int Marca { get; set; }
        public int TipoEquipo { get; set; }

        public MarcaDTO MarcaNavigation { get; set; }
        public TipoEquipoDTO TipoEquipoNavigation { get; set; }
        public IList<EquipoDTO> Tbequipo { get; set; }
        public IList<ProductoDTO> Tbproducto { get; set; }
    }
}
