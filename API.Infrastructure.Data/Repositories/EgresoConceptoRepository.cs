using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class EgresoConceptoRepository : IEgresoConcepto<Tbegresoconcepto>
    {
        private readonly soport43_minegociopruebasContext _context;

        public EgresoConceptoRepository(soport43_minegociopruebasContext context)
        {
            _context = context;
        }
        public async Task<bool> Delete(Tbegresoconcepto entity)
        {
            if (await Exists(entity))
            {
                _context.Tbegresoconcepto.Remove(entity);
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

        public async Task<bool> Exists(Tbegresoconcepto entity)
        {
            return await _context.Tbegresoconcepto.AnyAsync(e => e.IdEgreso == entity.IdEgreso);
        }

        public async Task<IEnumerable<Tbegresoconcepto>> Get()
        {
            return await _context.Tbegresoconcepto
                .OrderBy(x => x.IdEgreso)
                .ToListAsync();
        }

        public async Task<Tbegresoconcepto> GetById(Tbegresoconcepto entity)
        {
            return await _context.Tbegresoconcepto
               .Where(x => x.IdEgreso == entity.IdEgreso)
               .FirstOrDefaultAsync();
        }

        public async Task<Tbegresoconcepto> Post(Tbegresoconcepto entity)
        {
            await _context.Tbegresoconcepto.AddAsync(entity);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return await GetById(entity);
            else
                return null;
        }

        public async Task<Tbegresoconcepto> Put(Tbegresoconcepto entity)
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
