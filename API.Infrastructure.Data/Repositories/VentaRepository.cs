using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class VentaRepository : IVenta<Tbventa>
    {
        private readonly soport43_minegocioContext _context;

        public VentaRepository(soport43_minegocioContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(Tbventa entity)
        {
            if (await Exists(entity))
            {
                _context.Tbventa.Remove(entity);
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

        public async Task<bool> Exists(Tbventa entity)
        {
            return await _context.Tbventa.AnyAsync(e => e.IdVenta == entity.IdVenta);

        }

        public async Task<IEnumerable<Tbventa>> Get()
        {
            return await _context.Tbventa
                .OrderBy(x => x.IdVenta)
                .ToListAsync();
        }

        public async Task<Tbventa> GetById(Tbventa entity)
        {
            return await _context.Tbventa
                .Where(x => x.IdVenta == entity.IdVenta)
                .FirstOrDefaultAsync();
        }

        public async Task<Tbventa> Post(Tbventa entity)
        {
            await _context.Tbventa.AddAsync(entity);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return await GetById(entity);
            else
                return null;
        }

        public async Task<Tbventa> Put(Tbventa entity)
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
