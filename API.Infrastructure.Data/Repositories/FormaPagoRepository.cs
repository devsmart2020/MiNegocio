using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class FormaPagoRepository : IFormaPago<Tbformapago>
    {
        private readonly soport43_minegocioContext _context;

        public FormaPagoRepository(soport43_minegocioContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(Tbformapago entity)
        {
            if (await Exists(entity))
            {
                _context.Tbformapago.Remove(entity);
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

        public async Task<bool> Exists(Tbformapago entity)
        {
            return await _context.Tbformapago.AnyAsync(e => e.IdFormaPago == entity.IdFormaPago);

        }

        public async Task<IEnumerable<Tbformapago>> Get()
        {
            return await _context.Tbformapago
                .OrderBy(x => x.FormaPago)
                .ToListAsync();
        }

        public async Task<Tbformapago> GetById(Tbformapago entity)
        {
            return await _context.Tbformapago
                .Where(x => x.IdFormaPago == entity.IdFormaPago)
                .FirstOrDefaultAsync();
        }

        public async Task<Tbformapago> Post(Tbformapago entity)
        {
            await _context.Tbformapago.AddAsync(entity);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return await GetById(entity);
            else
                return null;
        }

        public async Task<Tbformapago> Put(Tbformapago entity)
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
