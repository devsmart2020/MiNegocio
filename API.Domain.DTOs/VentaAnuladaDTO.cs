using System;
using System.Collections.Generic;

namespace API.Domain.DTOs
{
    public class VentaAnuladaDTO
    {
        public int IdVenta { get; set; }
        public string IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public int? IdOrden { get; set; }
        public int IdFormaPago { get; set; }
        public string IdUsuario { get; set; }
        public string IdNegocio { get; set; }
        public string Observaciones { get; set; }

        public ClienteDTO IdClienteNavigation { get; set; }
        public FormaPagoDTO IdFormaPagoNavigation { get; set; }
        public NegocioDTO IdNegocioNavigation { get; set; }
        public UsuarioDTO IdUsuarioNavigation { get; set; }
        public IList<VentaProductoAnuladaDTO> Tbventaproductoanulada { get; set; }
    }
}
