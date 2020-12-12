using System;
using System.Collections.Generic;

namespace API.Domain.DTOs
{
    public class UsuarioDTO
    {
        public string DocId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NomCompleto { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public int IdPerfil { get; set; }
        public sbyte Estado { get; set; }
        public string CodigoRecuperacion { get; set; }
        public DateTime Fecha { get; set; }
        public string Token { get; set; }


        public PerfilDTO IdPerfilNavigation { get; set; }
        public IList<CompraDTO> Tbcompra { get; set; }
        public IList<OrdenDTO> Tborden { get; set; }
        public IList<UsuarioOrdenDTO> Tbusuarioorden { get; set; }
        public IList<VentaDTO> Tbventa { get; set; }
        public IList<VentaAnuladaDTO> Tbventaanulada { get; set; }
    }
}
