using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class ModeloRepository : IModelo<Tbmodelo>
    {
        private readonly soport43_minegocioContext _context;

        public ModeloRepository(soport43_minegocioContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(Tbmodelo entity)
        {
            if (await Exists(entity))
            {
                _context.Tbmodelo.Remove(entity);
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

        public async Task<bool> Exists(Tbmodelo entity)
        {
            return await _context.Tbmodelo.AnyAsync(e => e.IdModelo == entity.IdModelo);

        }

        public async Task<IEnumerable<Tbmodelo>> Get()
        {
            return await _context.Tbmodelo
                .OrderBy(x => x.Modelo)
                .ToListAsync();
        }

        public async Task<Tbmodelo> GetById(Tbmodelo entity)
        {
            return await _context.Tbmodelo
                .Where(x => x.IdModelo == entity.IdModelo)
                .FirstOrDefaultAsync();
        }

        public async Task<Tbmodelo> Post(Tbmodelo entity)
        {
            await _context.Tbmodelo.AddAsync(entity);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return await GetById(entity);
            else
                return null;
        }

        public async Task<Tbmodelo> Put(Tbmodelo entity)
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
