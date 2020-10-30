using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class CreditoRepository : ICredito<Tbcredito>
    {
        private readonly soport43_minegocioContext _context;

        public CreditoRepository(soport43_minegocioContext context)
        {
            _context = context;
        }
        public async Task<bool> Delete(Tbcredito entity)
        {
            if (await Exists(entity))
            {
                _context.Tbcredito.Remove(entity);
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

        public async Task<bool> Exists(Tbcredito entity)
        {
            return await _context.Tbcredito.AnyAsync(e => e.IdCredito == entity.IdCredito);
        }

        public async Task<IEnumerable<Tbcredito>> Get()
        {
            return await _context.Tbcredito
                .OrderBy(x => x.Fecha)
                .ToListAsync();
        }

        public async Task<Tbcredito> GetById(Tbcredito entity)
        {
            return await _context.Tbcredito
                .Where(x => x.IdCredito == entity.IdCredito)
                .FirstOrDefaultAsync();
        }

        public async Task<Tbcredito> Post(Tbcredito entity)
        {
            await _context.Tbcredito.AddAsync(entity);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return await GetById(entity);
            else
                return null;
        }

        public async Task<Tbcredito> Put(Tbcredito entity)
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
