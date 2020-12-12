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
    public class ReporteRepository : IReportes<ReporteDTO>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;
        public ReporteRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> Delete(ReporteDTO entity)
        {
            var model = await _context.Tbreportes.SingleOrDefaultAsync(x => x.IdReporte == entity.IdReporte);
            if (model == null)
                return false;
            _context.Tbreportes.Remove(model);
            int query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Exists(ReporteDTO entity)
        {
            return await _context.Tbreportes.AnyAsync(e => e.IdReporte == entity.IdReporte);
        }

        public async Task<IEnumerable<ReporteDTO>> Get()
        {
            return _mapper.Map<IEnumerable<ReporteDTO>>(await _context.Tbreportes.ToListAsync());
        }

        public async Task<ReporteDTO> GetById(ReporteDTO entity)
        {
            var model = await _context.Tbreportes.Where(x => x.IdReporte == entity.IdReporte).FirstOrDefaultAsync();
            return _mapper.Map<ReporteDTO>(model);
        }

        public async Task<bool> Post(ReporteDTO entity)
        {
            var model = _mapper.Map<Tbreportes>(entity);
            _context.Tbreportes.Add(model);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Put(ReporteDTO entity)
        {
            _context.Entry(_mapper.Map<Tbreportes>(entity)).State = EntityState.Modified;
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }
    }
}
