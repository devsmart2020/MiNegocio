namespace API.Domain.DTOs
{
    public class ReporteDTO
    {
        public int IdReporte { get; set; }
        public string Nombre { get; set; }
        public int IdTipoReporte { get; set; }

        public TipoReporteDTO IdTipoReporteNavigation { get; set; }
    }
}
