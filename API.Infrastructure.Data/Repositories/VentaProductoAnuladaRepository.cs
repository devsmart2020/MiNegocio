using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class VentaProductoAnuladaRepository : IVentaProductoAnulada<Tbventaproductoanulada>
    {
        private readonly soport43_minegocioContext _context;

        public VentaProductoAnuladaRepository(soport43_minegocioContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(Tbventaproductoanulada entity)
        {
            if (await Exists(entity))
            {
                _context.Tbventaproductoanulada.Remove(entity);
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

        public async Task<bool> Exists(Tbventaproductoanulada entity)
        {
            return await _context.Tbventaproductoanulada.AnyAsync(e => e.IdVenta == entity.IdVenta);

        }

        public async Task<IEnumerable<Tbventaproductoanulada>> Get()
        {
            return await _context.Tbventaproductoanulada
                .OrderBy(x => x.IdVenta)
                .ToListAsync();
        }

        public async Task<Tbventaproductoanulada> GetById(Tbventaproductoanulada entity)
        {
            return await _context.Tbventaproductoanulada
                .Where(x => x.IdVenta == entity.IdVenta)
                .FirstOrDefaultAsync();
        }

        public async Task<Tbventaproductoanulada> Post(Tbventaproductoanulada entity)
        {
            await _context.Tbventaproductoanulada.AddAsync(entity);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return await GetById(entity);
            else
                return null;
        }

        public async Task<Tbventaproductoanulada> Put(Tbventaproductoanulada entity)
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
