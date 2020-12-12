using System;
using System.Collections.Generic;

namespace API.Domain.DTOs
{
    public class ProductoDTO
    {
        public string IdProducto { get; set; }
        public string Producto { get; set; }
        public int Costo { get; set; }
        public int VlrVenta { get; set; }
        public int StockMinimo { get; set; }
        public int StockMaximo { get; set; }
        public int Existencia { get; set; }
        public int IdTipoProducto { get; set; }
        public int? IdModelo { get; set; }
        public string IdProveedor { get; set; }
        public DateTime Fecha { get; set; }

        public ModeloDTO IdModeloNavigation { get; set; }
        public ProveedorDTO IdProveedorNavigation { get; set; }
        public TipoProductoDTO IdTipoProductoNavigation { get; set; }
        public IList<ProductoSerialDTO> Tbproductoserial { get; set; }
        public IList<VentaProductoDTO> Tbventaproducto { get; set; }
        public IList<VentaProductoAnuladaDTO> Tbventaproductoanulada { get; set; }
    }
}
