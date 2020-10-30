using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class ProductoSerialRepository : IProductoSerial<Tbproductoserial>
    {
        private readonly soport43_minegocioContext _context;

        public ProductoSerialRepository(soport43_minegocioContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(Tbproductoserial entity)
        {
            if (await Exists(entity))
            {
                _context.Tbproductoserial.Remove(entity);
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

        public async Task<bool> Exists(Tbproductoserial entity)
        {
            return await _context.Tbproductoserial.AnyAsync(e => e.IdProducto == entity.IdProducto);

        }

        public async Task<IEnumerable<Tbproductoserial>> Get()
        {
            return await _context.Tbproductoserial
                .OrderBy(x => x.IdProductoNavigation.Producto)
                .ToListAsync();
        }

        public async Task<Tbproductoserial> GetById(Tbproductoserial entity)
        {
            return await _context.Tbproductoserial
                .Where(x => x.IdProducto == entity.IdProducto)
                .FirstOrDefaultAsync();
        }

        public async Task<Tbproductoserial> Post(Tbproductoserial entity)
        {
            await _context.Tbproductoserial.AddAsync(entity);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return await GetById(entity);
            else
                return null;
        }

        public async Task<Tbproductoserial> Put(Tbproductoserial entity)
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
