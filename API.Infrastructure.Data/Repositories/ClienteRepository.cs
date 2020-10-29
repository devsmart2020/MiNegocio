using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class ClienteRepository : ICliente<Tbcliente>
    {
        private readonly soport43_minegociopruebasContext _context;

        public ClienteRepository(soport43_minegociopruebasContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(Tbcliente entity)
        {
            if (await Exists(entity))
            {
                _context.Tbcliente.Remove(entity);
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

        public async Task<bool> Exists(Tbcliente entity)
        {
            return await _context.Tbcliente.AnyAsync(e => e.DocId == entity.DocId);
        }

        public async Task<IEnumerable<Tbcliente>> Get()
        {
            return await _context.Tbcliente
                .OrderBy(x => x.Nombres)
                .ToListAsync();
        }

        public async Task<Tbcliente> GetById(Tbcliente entity)
        {
            return await _context.Tbcliente.Where(x => x.DocId == entity.DocId)
                .FirstOrDefaultAsync();
        }

        public async Task<Tbcliente> Post(Tbcliente entity)
        {
            await _context.Tbcliente.AddAsync(entity);
            var query = await _context.SaveChangesAsync();
            if (query > 0)            
                return await GetById(entity);           
            else            
                return null;
            
        }

        public async Task<Tbcliente> Put(Tbcliente entity)
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
