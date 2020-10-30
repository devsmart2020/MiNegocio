using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class TipoReporteRepository : ITipoReporte<Tbtiporeporte>
    {
        private readonly soport43_minegocioContext _context;

        public TipoReporteRepository(soport43_minegocioContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(Tbtiporeporte entity)
        {
            if (await Exists(entity))
            {
                _context.Tbtiporeporte.Remove(entity);
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

        public async Task<bool> Exists(Tbtiporeporte entity)
        {
            return await _context.Tbtiporeporte.AnyAsync(e => e.IdTipoReporte == entity.IdTipoReporte);

        }

        public async Task<IEnumerable<Tbtiporeporte>> Get()
        {
            return await _context.Tbtiporeporte
                .OrderBy(x => x.Nombre)
                .ToListAsync();
        }

        public async Task<Tbtiporeporte> GetById(Tbtiporeporte entity)
        {
            return await _context.Tbtiporeporte
                .Where(x => x.IdTipoReporte == entity.IdTipoReporte)
                .FirstOrDefaultAsync();
        }

        public async Task<Tbtiporeporte> Post(Tbtiporeporte entity)
        {
            await _context.Tbtiporeporte.AddAsync(entity);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return await GetById(entity);
            else
                return null;
        }

        public async Task<Tbtiporeporte> Put(Tbtiporeporte entity)
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
