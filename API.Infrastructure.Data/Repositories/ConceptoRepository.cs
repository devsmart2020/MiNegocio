using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class ConceptoRepository : IConcepto<Tbconcepto>
    {
        private readonly soport43_minegociopruebasContext _context;

        public ConceptoRepository(soport43_minegociopruebasContext context)
        {
            _context = context;
        }
        public async Task<bool> Delete(Tbconcepto entity)
        {
            if (await Exists(entity))
            {
                _context.Tbconcepto.Remove(entity);
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

        public async Task<bool> Exists(Tbconcepto entity)
        {
            return await _context.Tbconcepto.AnyAsync(e => e.IdConcepto == entity.IdConcepto);
        }

        public async Task<IEnumerable<Tbconcepto>> Get()
        {
            return await _context.Tbconcepto
               .OrderBy(x => x.Concepto)
               .ToListAsync();
        }

        public async Task<Tbconcepto> GetById(Tbconcepto entity)
        {
            return await _context.Tbconcepto
                .Where(x => x.IdConcepto == entity.IdConcepto)
                .FirstOrDefaultAsync();
        }

        public async Task<Tbconcepto> Post(Tbconcepto entity)
        {
            await _context.Tbconcepto.AddAsync(entity);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return await GetById(entity);
            else
                return null;
        }

        public async Task<Tbconcepto> Put(Tbconcepto entity)
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
