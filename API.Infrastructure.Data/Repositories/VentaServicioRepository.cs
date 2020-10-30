using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class VentaServicioRepository : IVentaServicio<Tbventaservicio>
    {
        private readonly soport43_minegocioContext _context;

        public VentaServicioRepository(soport43_minegocioContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(Tbventaservicio entity)
        {
            if (await Exists(entity))
            {
                _context.Tbventaservicio.Remove(entity);
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

        public async Task<bool> Exists(Tbventaservicio entity)
        {
            return await _context.Tbventaservicio.AnyAsync(e => e.IdVenta == entity.IdVenta);

        }

        public async Task<IEnumerable<Tbventaservicio>> Get()
        {
            return await _context.Tbventaservicio
                .OrderBy(x => x.IdVenta)
                .ToListAsync();
        }

        public async Task<Tbventaservicio> GetById(Tbventaservicio entity)
        {
            return await _context.Tbventaservicio
                .Where(x => x.IdVenta == entity.IdVenta)
                .FirstOrDefaultAsync();
        }

        public async Task<Tbventaservicio> Post(Tbventaservicio entity)
        {
            await _context.Tbventaservicio.AddAsync(entity);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return await GetById(entity);
            else
                return null;
        }

        public async Task<Tbventaservicio> Put(Tbventaservicio entity)
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
