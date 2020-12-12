namespace MiNegocio.Models.Models
{
    public class EgresoConceptoDTO
    {
        public int IdEgreso { get; set; }
        public int IdConcepto { get; set; }
        public int VlrUnitario { get; set; }
        public int Cantidad { get; set; }
        public int? Descuento { get; set; }
        public string Observaciones { get; set; }

        public ConceptoDTO IdConceptoNavigation { get; set; }
        public EgresoDTO IdEgresoNavigation { get; set; }
    }
}
