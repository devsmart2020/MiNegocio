using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class EquipoRepository : IEquipo<Tbequipo>
    {
        private readonly soport43_minegocioContext _context;

        public EquipoRepository(soport43_minegocioContext context)
        {
            _context = context;
        }
        public async Task<bool> Delete(Tbequipo entity)
        {
            if (await Exists(entity))
            {
                _context.Tbequipo.Remove(entity);
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

        public async Task<bool> Exists(Tbequipo entity)
        {
            return await _context.Tbequipo.AnyAsync(e => e.IdEquipo == entity.IdEquipo);
        }

        public async Task<IEnumerable<Tbequipo>> Get()
        {
            return await _context.Tbequipo
                .OrderBy(x => x.Fecha)
                .ToListAsync();
        }

        public async Task<Tbequipo> GetById(Tbequipo entity)
        {
            return await _context.Tbequipo
                .Where(x => x.IdEquipo == entity.IdEquipo)
                .FirstOrDefaultAsync();
        }

        public async Task<Tbequipo> Post(Tbequipo entity)
        {
            await _context.Tbequipo.AddAsync(entity);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return await GetById(entity);
            else
                return null;
        }

        public async Task<Tbequipo> Put(Tbequipo entity)
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
