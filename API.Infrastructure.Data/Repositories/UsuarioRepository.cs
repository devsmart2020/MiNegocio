using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class UsuarioRepository : IUsuario<Tbusuario>
    {
        private readonly soport43_minegocioContext _context;

        public UsuarioRepository(soport43_minegocioContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(Tbusuario entity)
        {
            if (await Exists(entity))
            {
                _context.Tbusuario.Remove(entity);
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

        public async Task<bool> Exists(Tbusuario entity)
        {
            return await _context.Tbusuario.AnyAsync(e => e.DocId == entity.DocId);

        }

        public async Task<IEnumerable<Tbusuario>> Get()
        {
            return await _context.Tbusuario                
                .OrderBy(x => x.Nombres)
                .ToListAsync();
        }

        public async Task<Tbusuario> GetById(Tbusuario entity)
        {
            return await _context.Tbusuario
                .Where(x => x.DocId == entity.DocId)
                .FirstOrDefaultAsync();
        }

        public async Task<Tbusuario> Login(Tbusuario entity)
        {
            return await _context.Tbusuario
                .Where(x => x.User.Equals(entity.User) && x.Pass.Equals(entity.Pass))
                .FirstOrDefaultAsync();
        }

        public async Task<Tbusuario> Post(Tbusuario entity)
        {
            await _context.Tbusuario.AddAsync(entity);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return await GetById(entity);
            else
                return null;
        }

        public async Task<Tbusuario> Put(Tbusuario entity)
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
