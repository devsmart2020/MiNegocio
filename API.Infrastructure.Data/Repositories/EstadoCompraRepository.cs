using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class EstadoCompraRepository : IEstadoCompra<Tbestadocompra>
    {
        private readonly soport43_minegocioContext _context;

        public EstadoCompraRepository(soport43_minegocioContext context)
        {
            _context = context;
        }
        public async Task<bool> Delete(Tbestadocompra entity)
        {
            if (await Exists(entity))
            {
                _context.Tbestadocompra.Remove(entity);
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

        public async Task<bool> Exists(Tbestadocompra entity)
        {
            return await _context.Tbestadocompra.AnyAsync(e => e.IdEstadoCompra == entity.IdEstadoCompra);
        }

        public async Task<IEnumerable<Tbestadocompra>> Get()
        {
            return await _context.Tbestadocompra
               .OrderBy(x => x.IdEstadoCompra)
               .ToListAsync();
        }

        public async Task<Tbestadocompra> GetById(Tbestadocompra entity)
        {
            return await _context.Tbestadocompra
                .Where(x => x.IdEstadoCompra == entity.IdEstadoCompra)
                .FirstOrDefaultAsync();
        }

        public async Task<Tbestadocompra> Post(Tbestadocompra entity)
        {
            await _context.Tbestadocompra.AddAsync(entity);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return await GetById(entity);
            else
                return null;
        }

        public async Task<Tbestadocompra> Put(Tbestadocompra entity)
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
