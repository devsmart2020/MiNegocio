using API.Domain.DTOs;
using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class ClienteRepository : ICliente<ClienteDTO>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;

        public ClienteRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Delete(ClienteDTO entity)
        {
            var model = await _context.Tbcliente.SingleOrDefaultAsync(x => x.DocId == entity.DocId);
            if (model == null)
                return false;
            _context.Tbcliente.Remove(model);
            int query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Exists(ClienteDTO entity)
        {
            return await _context.Tbcliente.AnyAsync(e => e.DocId == entity.DocId);
        }

        public async Task<IEnumerable<ClienteDTO>> Get()
        {
            return _mapper.Map<IEnumerable<ClienteDTO>>(await _context.Tbcliente.ToListAsync());
        }

        public async Task<ClienteDTO> GetById(ClienteDTO entity)
        {
            var model = await _context.Tbcliente.Where(x => x.DocId == entity.DocId).FirstOrDefaultAsync();
            return _mapper.Map<ClienteDTO>(model);
        }

        public async Task<bool> Post(ClienteDTO entity)
        {
            var model = _mapper.Map<Tbcliente>(entity);
            _context.Tbcliente.Add(model);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Put(ClienteDTO entity)
        {
            _context.Entry(_mapper.Map<Tbcliente>(entity)).State = EntityState.Modified;
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<IEnumerable<ClienteDTO>> RptEquiposxCliente(ClienteDTO entity)
        {

            var model = await _context.Tbcliente
               .Where(x => x.DocId.Equals(entity.DocId))
               .Select(x => new ClienteDTO
               {
                   DocId = x.DocId,
                   Nombres = x.Nombres,
                   Apellidos = x.Apellidos,
                   Direccion = x.Direccion,
                   Telefono = x.Telefono,
                   TelAlternativo = x.TelAlternativo,
                   Email = x.Email,
                   Estado = x.Estado,
                   CodRecuperacion = x.CodRecuperacion,
                   Fecha = x.Fecha,
                   Tbequipo = x.Tbequipo.Where(e => e.IdCliente.Equals(x.DocId))
                   .Select(n => new EquipoDTO
                   {
                       IdEquipo = n.IdEquipo,
                       Fecha = n.Fecha,
                       IdTipoEquipo = n.IdModeloNavigation.TipoEquipoNavigation.IdTipoEquipo,
                       TipoEquipo = n.IdModeloNavigation.TipoEquipoNavigation.TipoEquipo,
                       IdMarca = n.IdModeloNavigation.Marca,
                       Marca = n.IdModeloNavigation.MarcaNavigation.Marca,
                       IdModelo = n.IdModelo,                     
                       Modelo = n.IdModeloNavigation.Modelo,
                       Serie = n.Serie,
                       Imei1 = n.Imei1,
                       Imei2 = n.Imei2,
                       Color = n.Color,
                       Observacion = n.Observacion
                   }).ToList()
               }).ToListAsync();
            return _mapper.Map<IEnumerable<ClienteDTO>>(model);
        }

        public async Task<IEnumerable<ClienteDTO>> RptOrdenxCliente(ClienteDTO entity)
        {
            var model = await _context.Tbcliente
            .Where(x => x.DocId.Equals(entity.DocId))
            .Select(x => new ClienteDTO
            {
                DocId = x.DocId,
                Nombres = x.Nombres,
                Apellidos = x.Apellidos,
                Telefono = x.Telefono,
                Tborden = x.Tborden.Where(o => o.IdCliente.Equals(x.DocId))
                .Select(n => new OrdenDTO
                {
                    IdOrden = n.IdOrden,
                    IdTipoEquipo = n.IdEquipoNavigation.IdModeloNavigation.TipoEquipoNavigation.IdTipoEquipo,
                    TipoEquipo = n.IdEquipoNavigation.IdModeloNavigation.TipoEquipoNavigation.TipoEquipo,                    
                    Marca = n.IdEquipoNavigation.IdModeloNavigation.MarcaNavigation.Marca,
                    Equipo = n.IdEquipoNavigation.IdModeloNavigation.Modelo,
                    IdCliente = n.IdCliente,
                    FechaEntra = n.FechaEntra,
                    FechaSale = n.FechaSale,
                    MicroSd = n.MicroSd,
                    Sim = n.Sim,
                    DatosBloqueo = n.DatosBloqueo,
                    DiagnosticoCliente = n.DiagnosticoCliente,
                    DiagnosticoTecnico = n.DiagnosticoTecnico,
                    Ubicacion = n.Ubicacion,
                    IdUsuario = n.IdUsuario,
                    IdEstadoOrden = n.IdEstadoOrden
                }).ToList()
            }).ToListAsync();
            return _mapper.Map<IEnumerable<ClienteDTO>>(model);
        }
    }
}
