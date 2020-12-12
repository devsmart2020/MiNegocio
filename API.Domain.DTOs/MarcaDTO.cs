using System.Collections.Generic;

namespace API.Domain.DTOs
{
    public class MarcaDTO
    {
        public int IdMarca { get; set; }
        public string Marca { get; set; }

        public IList<ModeloDTO> Tbmodelo { get; set; }
    }
}
