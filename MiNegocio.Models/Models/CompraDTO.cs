using System;

namespace MiNegocio.Models.Models
{
    public class CompraDTO
    {
        public int IdCompra { get; set; }
        public DateTime Fecha { get; set; }
        public string IdProveedor { get; set; }
        public string Nfactura { get; set; }
        public int IdEstadoCompra { get; set; }
        public int VlrCompra { get; set; }
        public string Observaciones { get; set; }
        public string IdUsuario { get; set; }

        public EstadoCompraDTO IdEstadoCompraNavigation { get; set; }
        public ProveedorDTO IdProveedorNavigation { get; set; }
        public UsuarioDTO IdUsuarioNavigation { get; set; }
    }
}
