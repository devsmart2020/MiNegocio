using System;
using System.Collections.Generic;

namespace API.Domain.DTOs
{
    public class ProveedorDTO
    {
        public string IdProveedor { get; set; }
        public string Proveedor { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public sbyte Estado { get; set; }
        public DateTime Fecha { get; set; }

        public IList<CompraDTO> Tbcompra { get; set; }
        public IList<ProductoDTO> Tbproducto { get; set; }
    }
}
