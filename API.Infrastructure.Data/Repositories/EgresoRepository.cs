using API.Domain.DTOs;
using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class EgresoRepository : IEgreso<EgresoDTO>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;

        public EgresoRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Delete(EgresoDTO entity)
        {
            var model = await _context.Tbegreso.SingleOrDefaultAsync(x => x.IdEgreso == entity.IdEgreso);
            if (model == null)
                return false;
            _context.Tbegreso.Remove(model);
            int query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Exists(EgresoDTO entity)
        {
            return await _context.Tbegreso.AnyAsync(e => e.IdEgreso == entity.IdEgreso);
        }

        public async Task<IEnumerable<EgresoDTO>> Get()
        {
            return _mapper.Map<IEnumerable<EgresoDTO>>(await _context.Tbegreso.ToListAsync());
        }

        public async Task<EgresoDTO> GetById(EgresoDTO entity)
        {
            var model = await _context.Tbegreso.Where(x => x.IdEgreso == entity.IdEgreso).FirstOrDefaultAsync();
            return _mapper.Map<EgresoDTO>(model);
        }

        public async Task<bool> Post(EgresoDTO entity)
        {
            var model = _mapper.Map<Tbegreso>(entity);
            _context.Tbegreso.Add(model);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Put(EgresoDTO entity)
        {
            _context.Entry(_mapper.Map<Tbegreso>(entity)).State = EntityState.Modified;
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }
    }
}
