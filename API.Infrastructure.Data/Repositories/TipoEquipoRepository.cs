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
    public class TipoEquipoRepository : ITipoEquipo<TipoEquipoDTO>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;
        public TipoEquipoRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Delete(TipoEquipoDTO entity)
        {
            var model = await _context.Tbtipoequipo.SingleOrDefaultAsync(x => x.IdTipoEquipo == entity.IdTipoEquipo);
            if (model == null)
                return false;
            _context.Tbtipoequipo.Remove(model);
            int query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Exists(TipoEquipoDTO entity)
        {
            return await _context.Tbtipoequipo.AnyAsync(e => e.IdTipoEquipo == entity.IdTipoEquipo);
        }

        public async Task<IEnumerable<TipoEquipoDTO>> Get()
        {
            return _mapper.Map<IEnumerable<TipoEquipoDTO>>(await _context.Tbtipoequipo.ToListAsync());
        }

        public async Task<TipoEquipoDTO> GetById(TipoEquipoDTO entity)
        {
            var model = await _context.Tbtipoequipo.Where(x => x.IdTipoEquipo == entity.IdTipoEquipo).FirstOrDefaultAsync();
            return _mapper.Map<TipoEquipoDTO>(model);
        }

        public async Task<bool> Post(TipoEquipoDTO entity)
        {
            var model = _mapper.Map<Tbtipoequipo>(entity);
            _context.Tbtipoequipo.Add(model);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Put(TipoEquipoDTO entity)
        {
            _context.Entry(_mapper.Map<Tbtipoequipo>(entity)).State = EntityState.Modified;
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }
    }
}
