using System;

namespace MiNegocio.Models.Models
{
    public class InventarioFijoDTO
    {
        public string IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Serial { get; set; }
        public int Costo { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
    }
}
