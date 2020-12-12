namespace MiNegocio.Models.Models
{
    public class VentaServicioDTO
    {
        public int IdVenta { get; set; }
        public int IdServicio { get; set; }
        public int VlrServicio { get; set; }
        public int Cantidad { get; set; }
        public int Descuento { get; set; }

        public ServicioDTO IdServicioNavigation { get; set; }
        public VentaDTO IdVentaNavigation { get; set; }
    }
}
