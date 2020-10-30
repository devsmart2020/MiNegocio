using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class PerfilRepository : IPerfil<Tbperfil>
    {
        private readonly soport43_minegocioContext _context;

        public PerfilRepository(soport43_minegocioContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(Tbperfil entity)
        {
            if (await Exists(entity))
            {
                _context.Tbperfil.Remove(entity);
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

        public async Task<bool> Exists(Tbperfil entity)
        {
            return await _context.Tbperfil.AnyAsync(e => e.IdPerfil == entity.IdPerfil);

        }

        public async Task<IEnumerable<Tbperfil>> Get()
        {
            return await _context.Tbperfil
                .OrderBy(x => x.Perfil)
                .ToListAsync();
        }

        public async Task<Tbperfil> GetById(Tbperfil entity)
        {
            return await _context.Tbperfil
                .Where(x => x.IdPerfil == entity.IdPerfil)
                .FirstOrDefaultAsync();
        }

        public async Task<Tbperfil> Post(Tbperfil entity)
        {
            await _context.Tbperfil.AddAsync(entity);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return await GetById(entity);
            else
                return null;
        }

        public async Task<Tbperfil> Put(Tbperfil entity)
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
