using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class InventarioFijoRepository : IInventarioFijo<Tbinventariofijo>
    {
        private readonly soport43_minegocioContext _context;

        public InventarioFijoRepository(soport43_minegocioContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(Tbinventariofijo entity)
        {
            if (await Exists(entity))
            {
                _context.Tbinventariofijo.Remove(entity);
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

        public async Task<bool> Exists(Tbinventariofijo entity)
        {
            return await _context.Tbinventariofijo.AnyAsync(e => e.IdProducto == entity.IdProducto);

        }

        public async Task<IEnumerable<Tbinventariofijo>> Get()
        {
            return await _context.Tbinventariofijo
                .OrderBy(x => x.Nombre)
                .ToListAsync();
        }

        public async Task<Tbinventariofijo> GetById(Tbinventariofijo entity)
        {
            return await _context.Tbinventariofijo
                .Where(x => x.IdProducto == entity.IdProducto)
                .FirstOrDefaultAsync();
        }

        public async Task<Tbinventariofijo> Post(Tbinventariofijo entity)
        {
            await _context.Tbinventariofijo.AddAsync(entity);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return await GetById(entity);
            else
                return null;
        }

        public async Task<Tbinventariofijo> Put(Tbinventariofijo entity)
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
