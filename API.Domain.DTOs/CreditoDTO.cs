using System;

namespace API.Domain.DTOs
{
    public class CreditoDTO
    {
        public int IdCredito { get; set; }
        public int IdVenta { get; set; }
        public DateTime Fecha { get; set; }
        public int Cartera { get; set; }
        public int Abono { get; set; }
        public sbyte PazySalvo { get; set; }

        public VentaDTO IdVentaNavigation { get; set; }
    }
}
