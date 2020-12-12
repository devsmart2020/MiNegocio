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
    public class TipoServicioRepository : ITipoServicio<TipoServicioDTO>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;
        public TipoServicioRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Delete(TipoServicioDTO entity)
        {
            var model = await _context.Tbtiposervicio.SingleOrDefaultAsync(x => x.IdTipoServicio == entity.IdTipoServicio);
            if (model == null)
                return false;
            _context.Tbtiposervicio.Remove(model);
            int query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Exists(TipoServicioDTO entity)
        {
            return await _context.Tbtiposervicio.AnyAsync(e => e.IdTipoServicio == entity.IdTipoServicio);
        }

        public async Task<IEnumerable<TipoServicioDTO>> Get()
        {
            return _mapper.Map<IEnumerable<TipoServicioDTO>>(await _context.Tbtiposervicio.ToListAsync());
        }

        public async Task<TipoServicioDTO> GetById(TipoServicioDTO entity)
        {
            var model = await _context.Tbtiposervicio.Where(x => x.IdTipoServicio == entity.IdTipoServicio).FirstOrDefaultAsync();
            return _mapper.Map<TipoServicioDTO>(model);
        }

        public async Task<bool> Post(TipoServicioDTO entity)
        {
            var model = _mapper.Map<Tbtiposervicio>(entity);
            _context.Tbtiposervicio.Add(model);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Put(TipoServicioDTO entity)
        {
            _context.Entry(_mapper.Map<Tbtiposervicio>(entity)).State = EntityState.Modified;
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }
    }
}
