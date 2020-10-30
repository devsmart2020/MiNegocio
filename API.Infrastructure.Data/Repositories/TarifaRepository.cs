using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class TarifaRepository : ITarifa<Tbtarifa>
    {
        private readonly soport43_minegocioContext _context;

        public TarifaRepository(soport43_minegocioContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(Tbtarifa entity)
        {
            if (await Exists(entity))
            {
                _context.Tbtarifa.Remove(entity);
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

        public async Task<bool> Exists(Tbtarifa entity)
        {
            return await _context.Tbtarifa.AnyAsync(e => e.IdTarifa == entity.IdTarifa);

        }

        public async Task<IEnumerable<Tbtarifa>> Get()
        {
            return await _context.Tbtarifa
                .OrderBy(x => x.Nombre)
                .ToListAsync();
        }

        public async Task<Tbtarifa> GetById(Tbtarifa entity)
        {
            return await _context.Tbtarifa
                .Where(x => x.IdTarifa == entity.IdTarifa)
                .FirstOrDefaultAsync();
        }

        public async Task<Tbtarifa> Post(Tbtarifa entity)
        {
            await _context.Tbtarifa.AddAsync(entity);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return await GetById(entity);
            else
                return null;
        }

        public async Task<Tbtarifa> Put(Tbtarifa entity)
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
