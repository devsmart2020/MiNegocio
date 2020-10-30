using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class TipoServicioRepository : ITipoServicio<Tbtiposervicio>
    {
        private readonly soport43_minegocioContext _context;

        public TipoServicioRepository(soport43_minegocioContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(Tbtiposervicio entity)
        {
            if (await Exists(entity))
            {
                _context.Tbtiposervicio.Remove(entity);
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

        public async Task<bool> Exists(Tbtiposervicio entity)
        {
            return await _context.Tbtiposervicio.AnyAsync(e => e.IdTipoServicio == entity.IdTipoServicio);

        }

        public async Task<IEnumerable<Tbtiposervicio>> Get()
        {
            return await _context.Tbtiposervicio
                .OrderBy(x => x.TipoServicio)
                .ToListAsync();
        }

        public async Task<Tbtiposervicio> GetById(Tbtiposervicio entity)
        {
            return await _context.Tbtiposervicio
                .Where(x => x.IdTipoServicio == entity.IdTipoServicio)
                .FirstOrDefaultAsync();
        }

        public async Task<Tbtiposervicio> Post(Tbtiposervicio entity)
        {
            await _context.Tbtiposervicio.AddAsync(entity);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return await GetById(entity);
            else
                return null;
        }

        public async Task<Tbtiposervicio> Put(Tbtiposervicio entity)
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
