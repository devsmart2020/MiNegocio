using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class ProveedorRepository : IProveedor<Tbproveedor>
    {
        private readonly soport43_minegocioContext _context;

        public ProveedorRepository(soport43_minegocioContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(Tbproveedor entity)
        {
            if (await Exists(entity))
            {
                _context.Tbproveedor.Remove(entity);
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

        public async Task<bool> Exists(Tbproveedor entity)
        {
            return await _context.Tbproveedor.AnyAsync(e => e.IdProveedor == entity.IdProveedor);

        }

        public async Task<IEnumerable<Tbproveedor>> Get()
        {
            return await _context.Tbproveedor
                .OrderBy(x => x.Proveedor)
                .ToListAsync();
        }

        public async Task<Tbproveedor> GetById(Tbproveedor entity)
        {
            return await _context.Tbproveedor
                .Where(x => x.IdProveedor == entity.IdProveedor)
                .FirstOrDefaultAsync();
        }

        public async Task<Tbproveedor> Post(Tbproveedor entity)
        {
            await _context.Tbproveedor.AddAsync(entity);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return await GetById(entity);
            else
                return null;
        }

        public async Task<Tbproveedor> Put(Tbproveedor entity)
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
