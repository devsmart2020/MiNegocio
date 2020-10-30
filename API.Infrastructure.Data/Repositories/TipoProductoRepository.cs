using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class TipoProductoRepository : ITipoProducto<Tbtipoproducto>
    {
        private readonly soport43_minegocioContext _context;

        public TipoProductoRepository(soport43_minegocioContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(Tbtipoproducto entity)
        {
            if (await Exists(entity))
            {
                _context.Tbtipoproducto.Remove(entity);
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

        public async Task<bool> Exists(Tbtipoproducto entity)
        {
            return await _context.Tbtipoproducto.AnyAsync(e => e.IdTipoProducto == entity.IdTipoProducto);

        }

        public async Task<IEnumerable<Tbtipoproducto>> Get()
        {
            return await _context.Tbtipoproducto
                .OrderBy(x => x.TipoProducto)
                .ToListAsync();
        }

        public async Task<Tbtipoproducto> GetById(Tbtipoproducto entity)
        {
            return await _context.Tbtipoproducto
                .Where(x => x.IdTipoProducto == entity.IdTipoProducto)
                .FirstOrDefaultAsync();
        }

        public async Task<Tbtipoproducto> Post(Tbtipoproducto entity)
        {
            await _context.Tbtipoproducto.AddAsync(entity);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return await GetById(entity);
            else
                return null;
        }

        public async Task<Tbtipoproducto> Put(Tbtipoproducto entity)
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
