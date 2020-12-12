using API.Domain.DTOs;
using API.Domain.Entities;
using AutoMapper;

namespace API.Infrastructure.Data.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Tbcliente, ClienteDTO>();
            CreateMap<ClienteDTO, Tbcliente>();
            CreateMap<Tbcompra, CompraDTO>();
            CreateMap<CompraDTO, Tbcompra>();
            CreateMap<Tbconcepto, ConceptoDTO>();
            CreateMap<ConceptoDTO, Tbconcepto>();
            CreateMap<Tbcredito, CreditoDTO>();
            CreateMap<CreditoDTO, Tbcredito>();
            CreateMap<Tbegresoconcepto, EgresoConceptoDTO>();
            CreateMap<EgresoConceptoDTO, Tbegresoconcepto>();
            CreateMap<Tbegreso, EgresoDTO>();
            CreateMap<EgresoDTO, Tbegreso>();
            CreateMap<Tbequipo, EquipoDTO>();
            CreateMap<EquipoDTO, Tbequipo>();
            CreateMap<Tbestadocompra, EstadoCompraDTO>();
            CreateMap<EstadoCompraDTO, Tbestadocompra>();
            CreateMap<Tbestadoorden, EstadoOrdenDTO>();
            CreateMap<EstadoOrdenDTO, Tbestadoorden>();
            CreateMap<Tbformapago, FormaPagoDTO>();
            CreateMap<FormaPagoDTO, Tbformapago>();
            CreateMap<Tbinventariofijo, InventarioFijoDTO>();
            CreateMap<InventarioFijoDTO, Tbinventariofijo>();
            CreateMap<Tbmarca, MarcaDTO>();
            CreateMap<MarcaDTO, Tbmarca>();
            CreateMap<Tbmodelo, ModeloDTO>();
            CreateMap<ModeloDTO, Tbmodelo>();
            CreateMap<Tbnegocio, NegocioDTO>();
            CreateMap<NegocioDTO, Tbnegocio>();
            CreateMap<Tborden, OrdenDTO>();
            CreateMap<OrdenDTO, Tborden>();
            CreateMap<Tbperfil, PerfilDTO>();
            CreateMap<PerfilDTO, Tbperfil>();
            CreateMap<Tbproducto, ProductoDTO>();
            CreateMap<ProductoDTO, Tbproducto>();
            CreateMap<Tbproductoserial, ProductoSerialDTO>();
            CreateMap<ProductoSerialDTO, Tbproductoserial>();
            CreateMap<Tbproveedor, ProveedorDTO>();
            CreateMap<ProveedorDTO, Tbproveedor>();
            CreateMap<Tbreportes, ReporteDTO>();
            CreateMap<ReporteDTO, Tbreportes>();
            CreateMap<Tbservicio, ServicioDTO>();
            CreateMap<ServicioDTO, Tbservicio>();
            CreateMap<Tbtarifa, TarifaDTO>();
            CreateMap<TarifaDTO, Tbtarifa>();
            CreateMap<Tbtipoequipo, TipoEquipoDTO>();
            CreateMap<TipoEquipoDTO, Tbtipoequipo>();
            CreateMap<Tbtipoproducto, TipoProductoDTO>();
            CreateMap<TipoProductoDTO, Tbtipoproducto>();
            CreateMap<Tbtiporeporte, TipoReporteDTO>();
            CreateMap<TipoReporteDTO, Tbtiporeporte>();
            CreateMap<Tbtiposervicio, TipoServicioDTO>();
            CreateMap<TipoServicioDTO, Tbtiposervicio>();
            CreateMap<Tbusuario, UsuarioDTO>();
            CreateMap<UsuarioDTO, Tbusuario>();
            CreateMap<Tbusuarioorden, UsuarioOrdenDTO>();
            CreateMap<UsuarioOrdenDTO, Tbusuarioorden>();
            CreateMap<Tbventaanulada, VentaAnuladaDTO>();
            CreateMap<VentaAnuladaDTO, Tbventaanulada>();
            CreateMap<Tbventa, VentaDTO>();
            CreateMap<VentaDTO, Tbventa>();
            CreateMap<Tbventaproductoanulada, VentaProductoAnuladaDTO>();
            CreateMap<VentaProductoAnuladaDTO, Tbventaproductoanulada>();
            CreateMap<Tbventaproducto, VentaProductoDTO>();
            CreateMap<VentaProductoDTO, Tbventaproducto>();
            CreateMap<Tbventaservicio, VentaServicioDTO>();
            CreateMap<VentaServicioDTO, Tbventaservicio>();
        }
    }
}
