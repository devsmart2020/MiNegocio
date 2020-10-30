using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class VentaAnuladaRepository : IVentaAnulada<Tbventaanulada>
    {
        private readonly soport43_minegocioContext _context;

        public VentaAnuladaRepository(soport43_minegocioContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(Tbventaanulada entity)
        {
            if (await Exists(entity))
            {
                _context.Tbventaanulada.Remove(entity);
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

        public async Task<bool> Exists(Tbventaanulada entity)
        {
            return await _context.Tbventaanulada.AnyAsync(e => e.IdVenta == entity.IdVenta);

        }

        public async Task<IEnumerable<Tbventaanulada>> Get()
        {
            return await _context.Tbventaanulada
                .OrderBy(x => x.Fecha)
                .ToListAsync();
        }

        public async Task<Tbventaanulada> GetById(Tbventaanulada entity)
        {
            return await _context.Tbventaanulada
                .Where(x => x.IdVenta == entity.IdVenta)
                .FirstOrDefaultAsync();
        }

        public async Task<Tbventaanulada> Post(Tbventaanulada entity)
        {
            await _context.Tbventaanulada.AddAsync(entity);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return await GetById(entity);
            else
                return null;
        }

        public async Task<Tbventaanulada> Put(Tbventaanulada entity)
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
