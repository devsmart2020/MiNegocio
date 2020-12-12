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
    public class TipoReporteRepository : ITipoReporte<TipoReporteDTO>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;
        public TipoReporteRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Delete(TipoReporteDTO entity)
        {
            var model = await _context.Tbtiporeporte.SingleOrDefaultAsync(x => x.IdTipoReporte == entity.IdTipoReporte);
            if (model == null)
                return false;
            _context.Tbtiporeporte.Remove(model);
            int query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Exists(TipoReporteDTO entity)
        {
            return await _context.Tbtiporeporte.AnyAsync(e => e.IdTipoReporte == entity.IdTipoReporte);
        }

        public async Task<IEnumerable<TipoReporteDTO>> Get()
        {
            return _mapper.Map<IEnumerable<TipoReporteDTO>>(await _context.Tbtiporeporte.ToListAsync());
        }

        public async Task<TipoReporteDTO> GetById(TipoReporteDTO entity)
        {
            var model = await _context.Tbtiporeporte.Where(x => x.IdTipoReporte == entity.IdTipoReporte).FirstOrDefaultAsync();
            return _mapper.Map<TipoReporteDTO>(model);
        }

        public async Task<bool> Post(TipoReporteDTO entity)
        {
            var model = _mapper.Map<Tbtiporeporte>(entity);
            _context.Tbtiporeporte.Add(model);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Put(TipoReporteDTO entity)
        {
            _context.Entry(_mapper.Map<Tbtiporeporte>(entity)).State = EntityState.Modified;
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }
    }
}
