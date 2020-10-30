using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class OrdenRepository : IOrden<Tborden>
    {
        private readonly soport43_minegocioContext _context;

        public OrdenRepository(soport43_minegocioContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(Tborden entity)
        {
            if (await Exists(entity))
            {
                _context.Tborden.Remove(entity);
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

        public async Task<bool> Exists(Tborden entity)
        {
            return await _context.Tborden.AnyAsync(e => e.IdOrden == entity.IdOrden);

        }

        public async Task<IEnumerable<Tborden>> Get()
        {
            return await _context.Tborden
                .OrderBy(x => x.FechaEntra)
                .ToListAsync();
        }

        public async Task<Tborden> GetById(Tborden entity)
        {
            return await _context.Tborden
                .Where(x => x.IdOrden == entity.IdOrden)
                .FirstOrDefaultAsync();
        }

        public async Task<Tborden> Post(Tborden entity)
        {
            await _context.Tborden.AddAsync(entity);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return await GetById(entity);
            else
                return null;
        }

        public async Task<Tborden> Put(Tborden entity)
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
