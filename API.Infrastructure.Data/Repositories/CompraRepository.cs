using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class CompraRepository : ICompra<Tbcompra>
    {
        private readonly soport43_minegociopruebasContext _context;

        public CompraRepository(soport43_minegociopruebasContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(Tbcompra entity)
        {
            if (await Exists(entity))
            {
                _context.Tbcompra.Remove(entity);
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

        public async Task<bool> Exists(Tbcompra entity)
        {
            return await _context.Tbcompra.AnyAsync(e => e.IdCompra == entity.IdCompra);
        }

        public async Task<IEnumerable<Tbcompra>> Get()
        {
            return await _context.Tbcompra
                .OrderBy(x => x.Fecha)
                .ToListAsync();
        }

        public async Task<Tbcompra> GetById(Tbcompra entity)
        {
            return await _context.Tbcompra
                .Where(x => x.IdCompra == entity.IdCompra)
                .FirstOrDefaultAsync();
        }

        public async Task<Tbcompra> Post(Tbcompra entity)
        {
            await _context.Tbcompra.AddAsync(entity);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return await GetById(entity);
            else
                return null;
        }

        public async Task<Tbcompra> Put(Tbcompra entity)
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
