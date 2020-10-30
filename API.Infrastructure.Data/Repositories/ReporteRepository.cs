using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class ReporteRepository : IReportes<Tbreportes>
    {
        private readonly soport43_minegocioContext _context;

        public ReporteRepository(soport43_minegocioContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(Tbreportes entity)
        {
            if (await Exists(entity))
            {
                _context.Tbreportes.Remove(entity);
                var query = await _context.SaveChangesAsync();
                if (query > 0)
                    return true;
                else
                    return false;

            }
            else
            {
                return false;
            }
        }

        public async Task<bool> Exists(Tbreportes entity)
        {
            return await _context.Tbreportes.AnyAsync(e => e.IdReporte == entity.IdReporte);

        }

        public async Task<IEnumerable<Tbreportes>> Get()
        {
            return await _context.Tbreportes
                .OrderBy(x => x.Nombre)
                .ToListAsync();
        }

        public async Task<Tbreportes> GetById(Tbreportes entity)
        {
            return await _context.Tbreportes
                .Where(x => x.IdReporte == entity.IdReporte)
                .FirstOrDefaultAsync();
        }

        public async Task<Tbreportes> Post(Tbreportes entity)
        {
            await _context.Tbreportes.AddAsync(entity);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return await GetById(entity);
            else
                return null;
        }

        public async Task<Tbreportes> Put(Tbreportes entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            try
            {
                var query = await _context.SaveChangesAsync();
                if (query > 0)
                    return await GetById(entity);
                else
                    return null;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await Exists(entity))
                    return null;
                else
                    throw;
            }
        }
    }
}
