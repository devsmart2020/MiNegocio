using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class TipoEquipoRepository : ITipoEquipo<Tbtipoequipo>
    {
        private readonly soport43_minegocioContext _context;

        public TipoEquipoRepository(soport43_minegocioContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(Tbtipoequipo entity)
        {
            if (await Exists(entity))
            {
                _context.Tbtipoequipo.Remove(entity);
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

        public async Task<bool> Exists(Tbtipoequipo entity)
        {
            return await _context.Tbtipoequipo.AnyAsync(e => e.IdTipoEquipo == entity.IdTipoEquipo);

        }

        public async Task<IEnumerable<Tbtipoequipo>> Get()
        {
            return await _context.Tbtipoequipo
                .OrderBy(x => x.TipoEquipo)
                .ToListAsync();
        }

        public async Task<Tbtipoequipo> GetById(Tbtipoequipo entity)
        {
            return await _context.Tbtipoequipo
                .Where(x => x.IdTipoEquipo == entity.IdTipoEquipo)
                .FirstOrDefaultAsync();
        }

        public async Task<Tbtipoequipo> Post(Tbtipoequipo entity)
        {
            await _context.Tbtipoequipo.AddAsync(entity);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return await GetById(entity);
            else
                return null;
        }

        public async Task<Tbtipoequipo> Put(Tbtipoequipo entity)
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
