using System.Collections.Generic;

namespace MiNegocio.Models.Models
{
    public class TipoProductoDTO
    {
        public int IdTipoProducto { get; set; }
        public string TipoProducto { get; set; }

        public IList<ProductoDTO> Tbproducto { get; set; }
    }
}
