using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class EgresoRepository : IEgreso<Tbegreso>
    {
        private readonly soport43_minegocioContext _context;

        public EgresoRepository(soport43_minegocioContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(Tbegreso entity)
        {
            if (await Exists(entity))
            {
                _context.Tbegreso.Remove(entity);
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

        public async Task<bool> Exists(Tbegreso entity)
        {
            return await _context.Tbegreso.AnyAsync(e => e.IdEgreso == entity.IdEgreso);

        }

        public async Task<IEnumerable<Tbegreso>> Get()
        {
            return await _context.Tbegreso
               .OrderBy(x => x.Fecha)
               .ToListAsync();
        }

        public async Task<Tbegreso> GetById(Tbegreso entity)
        {
            return await _context.Tbegreso
                .Where(x => x.IdEgreso == entity.IdEgreso)
                .FirstOrDefaultAsync();
        }

        public async Task<Tbegreso> Post(Tbegreso entity)
        {
            await _context.Tbegreso.AddAsync(entity);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return await GetById(entity);
            else
                return null;
        }

        public async Task<Tbegreso> Put(Tbegreso entity)
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
