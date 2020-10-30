using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class NegocioRepository : INegocio<Tbnegocio>
    {
        private readonly soport43_minegocioContext _context;

        public NegocioRepository(soport43_minegocioContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(Tbnegocio entity)
        {
            if (await Exists(entity))
            {
                _context.Tbnegocio.Remove(entity);
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

        public async Task<bool> Exists(Tbnegocio entity)
        {
            return await _context.Tbnegocio.AnyAsync(e => e.Nit == entity.Nit);

        }

        public async Task<IEnumerable<Tbnegocio>> Get()
        {
            return await _context.Tbnegocio
                .OrderBy(x => x.Nombre)
                .ToListAsync();
        }

        public async Task<Tbnegocio> GetById(Tbnegocio entity)
        {
            return await _context.Tbnegocio
                .Where(x => x.Nit == entity.Nit)
                .FirstOrDefaultAsync();
        }

        public async Task<Tbnegocio> Post(Tbnegocio entity)
        {
            await _context.Tbnegocio.AddAsync(entity);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return await GetById(entity);
            else
                return null;
        }

        public async Task<Tbnegocio> Put(Tbnegocio entity)
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
