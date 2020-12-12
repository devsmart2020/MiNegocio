﻿namespace MiNegocio.Models.Models
{
    public class VentaProductoDTO
    {
        public int IdVenta { get; set; }
        public string IdProducto { get; set; }
        public int Cantidad { get; set; }
        public int VlrProducto { get; set; }
        public int Descuento { get; set; }
        public string Serial1 { get; set; }
        public string Serial2 { get; set; }

        public ProductoDTO IdProductoNavigation { get; set; }
        public VentaDTO IdVentaNavigation { get; set; }
    }
}