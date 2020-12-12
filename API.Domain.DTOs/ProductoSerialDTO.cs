namespace API.Domain.DTOs
{
    public class ProductoSerialDTO
    {
        public string IdProducto { get; set; }
        public string Serie1 { get; set; }
        public string Serie2 { get; set; }
        public string Serial { get; set; }

        public ProductoDTO IdProductoNavigation { get; set; }
    }
}
