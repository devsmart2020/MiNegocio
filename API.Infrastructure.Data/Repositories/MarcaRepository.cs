using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class MarcaRepository : IMarca<Tbmarca>
    {
        private readonly soport43_minegocioContext _context;

        public MarcaRepository(soport43_minegocioContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(Tbmarca entity)
        {
            if (await Exists(entity))
            {
                _context.Tbmarca.Remove(entity);
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

        public async Task<bool> Exists(Tbmarca entity)
        {
            return await _context.Tbmarca.AnyAsync(e => e.IdMarca == entity.IdMarca);

        }

        public async Task<IEnumerable<Tbmarca>> Get()
        {
            return await _context.Tbmarca
                .OrderBy(x => x.Marca)
                .ToListAsync();
        }

        public async Task<Tbmarca> GetById(Tbmarca entity)
        {
            return await _context.Tbmarca
                .Where(x => x.IdMarca == entity.IdMarca)
                .FirstOrDefaultAsync();
        }

        public async Task<Tbmarca> Post(Tbmarca entity)
        {
            await _context.Tbmarca.AddAsync(entity);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return await GetById(entity);
            else
                return null;
        }

        public async Task<Tbmarca> Put(Tbmarca entity)
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
