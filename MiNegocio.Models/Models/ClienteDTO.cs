using System;
using System.Collections.Generic;

namespace MiNegocio.Models.Models
{
    public class ClienteDTO
    {
        public string DocId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string TelAlternativo { get; set; }
        public string Email { get; set; }
        public sbyte Estado { get; set; }
        public string CodRecuperacion { get; set; }
        public DateTime Fecha { get; set; }

        public IList<EquipoDTO> Tbequipo { get; set; }
        public IList<OrdenDTO> Tborden { get; set; }
        public IList<VentaDTO> Tbventa { get; set; }
        public IList<VentaAnuladaDTO> Tbventaanulada { get; set; }
    }
}
