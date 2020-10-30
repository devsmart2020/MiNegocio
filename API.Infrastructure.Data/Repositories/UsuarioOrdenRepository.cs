using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class UsuarioOrdenRepository : IUsuarioOrden<Tbusuarioorden>
    {
        private readonly soport43_minegocioContext _context;

        public UsuarioOrdenRepository(soport43_minegocioContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(Tbusuarioorden entity)
        {
            if (await Exists(entity))
            {
                _context.Tbusuarioorden.Remove(entity);
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

        public async Task<bool> Exists(Tbusuarioorden entity)
        {
            return await _context.Tbusuarioorden.AnyAsync(e => e.IdUsuario == entity.IdUsuario);

        }

        public async Task<IEnumerable<Tbusuarioorden>> Get()
        {
            return await _context.Tbusuarioorden
                .OrderBy(x => x.IdOrden)
                .ToListAsync();
        }

        public async Task<Tbusuarioorden> GetById(Tbusuarioorden entity)
        {
            return await _context.Tbusuarioorden
                .Where(x => x.IdUsuario == entity.IdUsuario)
                .FirstOrDefaultAsync();
        }

        public async Task<Tbusuarioorden> Post(Tbusuarioorden entity)
        {
            await _context.Tbusuarioorden.AddAsync(entity);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return await GetById(entity);
            else
                return null;
        }

        public async Task<Tbusuarioorden> Put(Tbusuarioorden entity)
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
