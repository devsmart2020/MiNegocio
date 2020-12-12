using System;
using System.Collections.Generic;

namespace API.Domain.DTOs
{
    public class EquipoDTO
    {
        public int IdEquipo { get; set; }
        public DateTime Fecha { get; set; }
        public string IdCliente { get; set; }
        public int IdTipoEquipo { get; set; }
        public string TipoEquipo { get; set; }
        public int IdMarca { get; set; }
        public string Marca { get; set; }
        public int IdModelo { get; set; }
        public string Modelo { get; set; }
        public string Serie { get; set; }
        public string Imei1 { get; set; }
        public string Imei2 { get; set; }
        public string Color { get; set; }
        public string Observacion { get; set; }

        public ClienteDTO IdClienteNavigation { get; set; }
        public ModeloDTO IdModeloNavigation { get; set; }
        public IList<OrdenDTO> Tborden { get; set; }
    }
}
