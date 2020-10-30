using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using API.Infrastructure.Data.Repositories;
using API.Services;
using Microsoft.IdentityModel.Tokens;
using API.Services.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Text;

namespace MiNegocio.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Configuarcion del servicio autenticación JWT
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = Configuration["JWT:Issuer"],
                        ValidAudience = Configuration["JWT:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:ClaveSecreta"]))
                    };
                });

            services.AddControllers();
            services.AddDbContext<soport43_minegocioContext>(options =>
            options.UseMySql(Configuration.GetConnectionString("prueba")));

            services.AddTransient<ICliente<Tbcliente>, ClienteRepository>();
            services.AddTransient<IClienteService<Tbcliente>, ClienteService>();
            services.AddTransient<ICompra<Tbcompra>, CompraRepository>();
            services.AddTransient<ICompraService<Tbcompra>, CompraService>();
            services.AddTransient<IConcepto<Tbconcepto>, ConceptoRepository>();
            services.AddTransient<IConceptoService<Tbconcepto>, ConceptoService>();
            services.AddTransient<ICredito<Tbcredito>, CreditoRepository>();
            services.AddTransient<ICreditoService<Tbcredito>, CreditoService>();
            services.AddTransient<IEgresoConcepto<Tbegresoconcepto>, EgresoConceptoRepository>();
            services.AddTransient<IEgresoConceptoService<Tbegresoconcepto>, EgresoConceptoService>();
            services.AddTransient<IEgreso<Tbegreso>, EgresoRepository>();
            services.AddTransient<IEgresoService<Tbegreso>, EgresoService>();
            services.AddTransient<IEquipo<Tbequipo>, EquipoRepository>();
            services.AddTransient<IEquipoService<Tbequipo>, EquipoService>();
            services.AddTransient<IEstadoCompra<Tbestadocompra>, EstadoCompraRepository>();
            services.AddTransient<IEstadoCompraService<Tbestadocompra>, EstadoCompraService>();
            services.AddTransient<IEstadoOrden<Tbestadoorden>, EstadoOrdenRepository>();
            services.AddTransient<IEstadoOrdenService<Tbestadoorden>, EstadoOrdenService>();
            services.AddTransient<IFormaPago<Tbformapago>, FormaPagoRepository>();
            services.AddTransient<IInventarioFijo<Tbinventariofijo>, InventarioFijoRepository>();
            services.AddTransient<IInventarioFijoService<Tbinventariofijo>, InventarioFijoService>();
            services.AddTransient<IMarca<Tbmarca>, MarcaRepository>();
            services.AddTransient<IMarcaService<Tbmarca>, MarcaService>();
            services.AddTransient<IModelo<Tbmodelo>, ModeloRepository>();
            services.AddTransient<IModeloService<Tbmodelo>, ModeloService>();
            services.AddTransient<INegocio<Tbnegocio>, NegocioRepository>();
            services.AddTransient<INegocioService<Tbnegocio>, NegocioService>();
            services.AddTransient<IOrden<Tborden>, OrdenRepository>();
            services.AddTransient<IOrdenService<Tborden>, OrdenService>();
            services.AddTransient<IPerfil<Tbperfil>, PerfilRepository>();
            services.AddTransient<IPerfilService<Tbperfil>, PerfilService>();
            services.AddTransient<IProducto<Tbproducto>, ProductoRepository>();
            services.AddTransient<IProductoService<Tbproducto>, ProductoService>();
            services.AddTransient<IProveedor<Tbproveedor>, ProveedorRepository>();
            services.AddTransient<IProveedorService<Tbproveedor>, ProveedorService>();
            services.AddTransient<IInventarioFijo<Tbinventariofijo>, InventarioFijoRepository>();
            services.AddTransient<IInventarioFijoService<Tbinventariofijo>, InventarioFijoService>();
            services.AddTransient<IReportes<Tbreportes>, ReporteRepository>();
            services.AddTransient<IReportesService<Tbreportes>, ReportesService>();
            services.AddTransient<IServicio<Tbservicio>, ServicioRepository>();
            services.AddTransient<IServicioService<Tbservicio>, ServicioService>();
            services.AddTransient<ITarifa<Tbtarifa>, TarifaRepository>();
            services.AddTransient<ITarifaService<Tbtarifa>, TarifaService>();
            services.AddTransient<ITipoEquipo<Tbtipoequipo>, TipoEquipoRepository>();
            services.AddTransient<ITipoEquipoService<Tbtipoequipo>, TipoEquipoService>();
            services.AddTransient<ITipoProducto<Tbtipoproducto>, TipoProductoRepository>();
            services.AddTransient<ITipoProductoService<Tbtipoproducto>, TipoProductoService>();
            services.AddTransient<ITipoReporte<Tbtiporeporte>, TipoReporteRepository>();
            services.AddTransient<ITipoReporteService<Tbtiporeporte>, TipoReporteService>();
            services.AddTransient<ITipoServicio<Tbtiposervicio>, TipoServicioRepository>();
            services.AddTransient<ITipoServicioService<Tbtiposervicio>, TipoServicioService>();
            services.AddTransient<IUsuarioOrden<Tbusuarioorden>, UsuarioOrdenRepository>();
            services.AddTransient<IUsuarioOrdenService<Tbusuarioorden>, UsuarioOrdenService>();
            services.AddTransient<IUsuario<Tbusuario>, UsuarioRepository>();
            services.AddTransient<IUsuarioService<Tbusuario>, UsuarioService>();
            services.AddTransient<IVentaAnulada<Tbventaanulada>, VentaAnuladaRepository>();
            services.AddTransient<IVentaAnuladaService<Tbventaanulada>, VentaAnuladaService>();
            services.AddTransient<IVentaProductoAnulada<Tbventaproductoanulada>, VentaProductoAnuladaRepository>();
            services.AddTransient<IVentaProductoAnuladaService<Tbventaproductoanulada>, VentaProductoAnuladaService>();
            services.AddTransient<IVentaProducto<Tbventaproducto>, VentaProductoRepository>();
            services.AddTransient<IVentaProductoService<Tbventaproducto>, VentaProductoService>();
            services.AddTransient<IVenta<Tbventa>, VentaRepository>();
            services.AddTransient<IVentaService<Tbventa>, VentaService>();
            services.AddTransient<IVentaServicio<Tbventaservicio>, VentaServicioRepository>();
            services.AddTransient<IVentaServicioService<Tbventaservicio>, VentaServicioService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();

            //Añadimos el Middleware de autenticacion de susuarios al pipeline de asp .net core
            app.UseAuthentication();
             
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
