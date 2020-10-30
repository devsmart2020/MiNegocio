﻿using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class ServicioRepository :IServicio<Tbservicio>
    {
        private readonly soport43_minegocioContext _context;

        public ServicioRepository(soport43_minegocioContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(Tbservicio entity)
        {
            if (await Exists(entity))
            {
                _context.Tbservicio.Remove(entity);
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

        public async Task<bool> Exists(Tbservicio entity)
        {
            return await _context.Tbservicio.AnyAsync(e => e.IdServicio == entity.IdServicio);

        }

        public async Task<IEnumerable<Tbservicio>> Get()
        {
            return await _context.Tbservicio
                .OrderBy(x => x.Servicio)
                .ToListAsync();
        }

        public async Task<Tbservicio> GetById(Tbservicio entity)
        {
            return await _context.Tbservicio
                .Where(x => x.IdServicio == entity.IdServicio)
                .FirstOrDefaultAsync();
        }

        public async Task<Tbservicio> Post(Tbservicio entity)
        {
            await _context.Tbservicio.AddAsync(entity);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return await GetById(entity);
            else
                return null;
        }

        public async Task<Tbservicio> Put(Tbservicio entity)
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
