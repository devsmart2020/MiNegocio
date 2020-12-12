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
    public class ServicioRepository : IServicio<ServicioDTO>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;
        public ServicioRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Delete(ServicioDTO entity)
        {
            var model = await _context.Tbservicio.SingleOrDefaultAsync(x => x.IdServicio == entity.IdServicio);
            if (model == null)
                return false;
            _context.Tbservicio.Remove(model);
            int query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Exists(ServicioDTO entity)
        {
            return await _context.Tbservicio.AnyAsync(e => e.IdServicio == entity.IdServicio);
        }

        public async Task<IEnumerable<ServicioDTO>> Get()
        {
            return _mapper.Map<IEnumerable<ServicioDTO>>(await _context.Tbservicio.ToListAsync());
        }

        public async Task<ServicioDTO> GetById(ServicioDTO entity)
        {
            var model = await _context.Tbservicio.Where(x => x.IdServicio == entity.IdServicio).FirstOrDefaultAsync();
            return _mapper.Map<ServicioDTO>(model);
        }

        public async Task<bool> Post(ServicioDTO entity)
        {
            var model = _mapper.Map<Tbservicio>(entity);
            _context.Tbservicio.Add(model);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Put(ServicioDTO entity)
        {
            _context.Entry(_mapper.Map<Tbservicio>(entity)).State = EntityState.Modified;
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }
    }
}
