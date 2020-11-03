using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class EstadoOrdenRepository : IEstadoOrden<Tbestadoorden>
    {
        private readonly soport43_minegocioContext _context;

        public EstadoOrdenRepository(soport43_minegocioContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(Tbestadoorden entity)
        {
            if (await Exists(entity))
            {
                _context.Tbestadoorden.Remove(entity);
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

        public async Task<bool> Exists(Tbestadoorden entity)
        {
            return await _context.Tbestadoorden.AnyAsync(e => e.IdEstadoOrden == entity.IdEstadoOrden);

        }

        public async Task<IEnumerable<Tbestadoorden>> Get()
        {
            return await _context.Tbestadoorden
                .OrderBy(x => x.IdEstadoOrden)
                .ToListAsync();
        }

        public async Task<Tbestadoorden> GetById(Tbestadoorden entity)
        {
            return await _context.Tbestadoorden
                .Where(x => x.IdEstadoOrden == entity.IdEstadoOrden)
                .FirstOrDefaultAsync();
        }

        public async Task<Tbestadoorden> Post(Tbestadoorden entity)
        {
            await _context.Tbestadoorden.AddAsync(entity);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return await GetById(entity);
            else
                return null;
        }

        public async Task<Tbestadoorden> Put(Tbestadoorden entity)
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
