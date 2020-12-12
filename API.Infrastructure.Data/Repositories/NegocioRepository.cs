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
    public class NegocioRepository : INegocio<NegocioDTO>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;
        public NegocioRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Delete(NegocioDTO entity)
        {
            var model = await _context.Tbnegocio.SingleOrDefaultAsync(x => x.Nit == entity.Nit);
            if (model == null)
                return false;
            _context.Tbnegocio.Remove(model);
            int query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Exists(NegocioDTO entity)
        {
            return await _context.Tbnegocio.AnyAsync(e => e.Nit == entity.Nit);
        }

        public async Task<IEnumerable<NegocioDTO>> Get()
        {
            return _mapper.Map<IEnumerable<NegocioDTO>>(await _context.Tbnegocio.ToListAsync());
        }

        public async Task<NegocioDTO> GetById(NegocioDTO entity)
        {
            var model = await _context.Tbnegocio.Where(x => x.Nit == entity.Nit).FirstOrDefaultAsync();
            return _mapper.Map<NegocioDTO>(model);
        }

        public async Task<bool> Post(NegocioDTO entity)
        {
            var model = _mapper.Map<Tbnegocio>(entity);
            _context.Tbnegocio.Add(model);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Put(NegocioDTO entity)
        {
            _context.Entry(_mapper.Map<Tbnegocio>(entity)).State = EntityState.Modified;
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }
    }
}
