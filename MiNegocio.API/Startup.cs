using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using API.Infrastructure.Data.Repositories;
using API.Services;
using API.Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System;
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
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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
            

            services.AddTransient<ICliente<ClienteDTO>, ClienteRepository>();
            services.AddTransient<IClienteService<ClienteDTO>, ClienteService>();
            services.AddTransient<ICompra<CompraDTO>, CompraRepository>();
            services.AddTransient<ICompraService<CompraDTO>, CompraService>();
            services.AddTransient<IConcepto<ConceptoDTO>, ConceptoRepository>();
            services.AddTransient<IConceptoService<ConceptoDTO>, ConceptoService>();
            services.AddTransient<ICredito<CreditoDTO>, CreditoRepository>();
            services.AddTransient<ICreditoService<CreditoDTO>, CreditoService>();
            services.AddTransient<IEgresoConcepto<EgresoConceptoDTO>, EgresoConceptoRepository>();
            services.AddTransient<IEgresoConceptoService<EgresoConceptoDTO>, EgresoConceptoService>();
            services.AddTransient<IEgreso<EgresoDTO>, EgresoRepository>();
            services.AddTransient<IEgresoService<EgresoDTO>, EgresoService>();
            services.AddTransient<IEquipo<EquipoDTO>, EquipoRepository>();
            services.AddTransient<IEquipoService<EquipoDTO>, EquipoService>();
            services.AddTransient<IEstadoCompra<EstadoCompraDTO>, EstadoCompraRepository>();
            services.AddTransient<IEstadoCompraService<EstadoCompraDTO>, EstadoCompraService>();
            services.AddTransient<IEstadoOrden<EstadoOrdenDTO>, EstadoOrdenRepository>();
            services.AddTransient<IEstadoOrdenService<EstadoOrdenDTO>, EstadoOrdenService>();
            services.AddTransient<IFormaPago<FormaPagoDTO>, FormaPagoRepository>();
            services.AddTransient<IFormaPagoService<FormaPagoDTO>, FormaPagoService>();
            services.AddTransient<IInventarioFijo<InventarioFijoDTO>, InventarioFijoRepository>();
            services.AddTransient<IInventarioFijoService<InventarioFijoDTO>, InventarioFijoService>();
            services.AddTransient<ILogin<UsuarioDTO>, LoginRepository>();
            services.AddTransient<ILoginService<UsuarioDTO>, LoginService>();
            services.AddTransient<IMarca<MarcaDTO>, MarcaRepository>();
            services.AddTransient<IMarcaService<MarcaDTO>, MarcaService>();
            services.AddTransient<IModelo<ModeloDTO>, ModeloRepository>();
            services.AddTransient<IModeloService<ModeloDTO>, ModeloService>();
            services.AddTransient<INegocio<NegocioDTO>, NegocioRepository>();
            services.AddTransient<INegocioService<NegocioDTO>, NegocioService>();
            services.AddTransient<IOrden<OrdenDTO>, OrdenRepository>();
            services.AddTransient<IOrdenService<OrdenDTO>, OrdenService>();
            services.AddTransient<IPerfil<PerfilDTO>, PerfilRepository>();
            services.AddTransient<IPerfilService<PerfilDTO>, PerfilService>();
            services.AddTransient<IProducto<ProductoDTO>, ProductoRepository>();
            services.AddTransient<IProductoService<ProductoDTO>, ProductoService>();
            services.AddTransient<IProveedor<ProveedorDTO>, ProveedorRepository>();
            services.AddTransient<IProveedorService<ProveedorDTO>, ProveedorService>();
            services.AddTransient<IInventarioFijo<InventarioFijoDTO>, InventarioFijoRepository>();
            services.AddTransient<IInventarioFijoService<InventarioFijoDTO>, InventarioFijoService>();
            services.AddTransient<IReportes<ReporteDTO>, ReporteRepository>();
            services.AddTransient<IReportesService<ReporteDTO>, ReportesService>();
            services.AddTransient<IServicio<ServicioDTO>, ServicioRepository>();
            services.AddTransient<IServicioService<ServicioDTO>, ServicioService>();
            services.AddTransient<ITarifa<TarifaDTO>, TarifaRepository>();
            services.AddTransient<ITarifaService<TarifaDTO>, TarifaService>();
            services.AddTransient<ITipoEquipo<TipoEquipoDTO>, TipoEquipoRepository>();
            services.AddTransient<ITipoEquipoService<TipoEquipoDTO>, TipoEquipoService>();
            services.AddTransient<ITipoProducto<TipoProductoDTO>, TipoProductoRepository>();
            services.AddTransient<ITipoProductoService<TipoProductoDTO>, TipoProductoService>();
            services.AddTransient<ITipoReporte<TipoReporteDTO>, TipoReporteRepository>();
            services.AddTransient<ITipoReporteService<TipoReporteDTO>, TipoReporteService>();
            services.AddTransient<ITipoServicio<TipoServicioDTO>, TipoServicioRepository>();
            services.AddTransient<ITipoServicioService<TipoServicioDTO>, TipoServicioService>();
            services.AddTransient<IUsuarioOrden<UsuarioOrdenDTO>, UsuarioOrdenRepository>();
            services.AddTransient<IUsuarioOrdenService<UsuarioOrdenDTO>, UsuarioOrdenService>();
            services.AddTransient<IUsuario<UsuarioDTO>, UsuarioRepository>();
            services.AddTransient<IUsuarioService<UsuarioDTO>, UsuarioService>();
            services.AddTransient<IVentaAnulada<VentaAnuladaDTO>, VentaAnuladaRepository>();
            services.AddTransient<IVentaAnuladaService<VentaAnuladaDTO>, VentaAnuladaService>();
            services.AddTransient<IVentaProductoAnulada<VentaProductoAnuladaDTO>, VentaProductoAnuladaRepository>();
            services.AddTransient<IVentaProductoAnuladaService<VentaProductoAnuladaDTO>, VentaProductoAnuladaService>();
            services.AddTransient<IVentaProducto<VentaProductoDTO>, VentaProductoRepository>();
            services.AddTransient<IVentaProductoService<VentaProductoDTO>, VentaProductoService>();
            services.AddTransient<IVenta<VentaDTO>, VentaRepository>();
            services.AddTransient<IVentaService<VentaDTO>, VentaService>();
            services.AddTransient<IVentaServicio<VentaServicioDTO>, VentaServicioRepository>();
            services.AddTransient<IVentaServicioService<VentaServicioDTO>, VentaServicioService>();
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
