using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class VentaProductoRepository : IVentaProducto<Tbventaproducto>
    {
        private readonly soport43_minegocioContext _context;

        public VentaProductoRepository(soport43_minegocioContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(Tbventaproducto entity)
        {
            if (await Exists(entity))
            {
                _context.Tbventaproducto.Remove(entity);
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

        public async Task<bool> Exists(Tbventaproducto entity)
        {
            return await _context.Tbventaproducto.AnyAsync(e => e.IdVenta == entity.IdVenta);

        }

        public async Task<IEnumerable<Tbventaproducto>> Get()
        {
            return await _context.Tbventaproducto
                .OrderBy(x => x.IdVenta)
                .ToListAsync();
        }

        public async Task<Tbventaproducto> GetById(Tbventaproducto entity)
        {
            return await _context.Tbventaproducto
                .Where(x => x.IdVenta == entity.IdVenta)
                .FirstOrDefaultAsync();
        }

        public async Task<Tbventaproducto> Post(Tbventaproducto entity)
        {
            await _context.Tbventaproducto.AddAsync(entity);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return await GetById(entity);
            else
                return null;
        }

        public async Task<Tbventaproducto> Put(Tbventaproducto entity)
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
