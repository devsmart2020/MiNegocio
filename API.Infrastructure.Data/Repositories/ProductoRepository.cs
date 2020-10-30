using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class ProductoRepository : IProducto<Tbproducto>
    {
        private readonly soport43_minegocioContext _context;

        public ProductoRepository(soport43_minegocioContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(Tbproducto entity)
        {
            if (await Exists(entity))
            {
                _context.Tbproducto.Remove(entity);
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

        public async Task<bool> Exists(Tbproducto entity)
        {
            return await _context.Tbproducto.AnyAsync(e => e.IdProducto == entity.IdProducto);

        }

        public async Task<IEnumerable<Tbproducto>> Get()
        {
            return await _context.Tbproducto
                .OrderBy(x => x.Producto)
                .ToListAsync();
        }

        public async Task<Tbproducto> GetById(Tbproducto entity)
        {
            return await _context.Tbproducto
                .Where(x => x.IdProducto == entity.IdProducto)
                .FirstOrDefaultAsync();
        }

        public async Task<Tbproducto> Post(Tbproducto entity)
        {
            await _context.Tbproducto.AddAsync(entity);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return await GetById(entity);
            else
                return null;
        }

        public async Task<Tbproducto> Put(Tbproducto entity)
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
