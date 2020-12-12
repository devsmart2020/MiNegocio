using System;
using System.Collections.Generic;

namespace API.Domain.DTOs
{
    public class OrdenDTO
    {
        public int IdOrden { get; set; }
        public string TipoEquipo { get; set; }
        public string Marca { get; set; }
        public string Equipo { get; set; }
        public DateTime FechaEntra { get; set; }
        public DateTime FechaRevision { get; set; }
        public DateTime FechaSale { get; set; }
        public string IdCliente { get; set; }
        public int IdTipoEquipo { get; set; }
        public int IdEquipo { get; set; }
        public int IdEstadoOrden { get; set; }
        public sbyte? MicroSd { get; set; }
        public sbyte? Sim { get; set; }
        public string DatosBloqueo { get; set; }
        public string Foto { get; set; }
        public string DiagnosticoCliente { get; set; }
        public string DiagnosticoTecnico { get; set; }
        public int? Presupuesto { get; set; }
        public string Ubicacion { get; set; }
        public string IdUsuario { get; set; }

        public ClienteDTO IdClienteNavigation { get; set; }
        public EquipoDTO IdEquipoNavigation { get; set; }
        public EstadoOrdenDTO IdEstadoOrdenNavigation { get; set; }
        public UsuarioDTO IdUsuarioNavigation { get; set; }
        public IList<UsuarioOrdenDTO> Tbusuarioorden { get; set; }
        public IList<VentaDTO> Tbventa { get; set; }
    }
}
