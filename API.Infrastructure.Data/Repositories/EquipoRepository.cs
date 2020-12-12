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
    public class EquipoRepository : IEquipo<EquipoDTO>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;

        public EquipoRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> Delete(EquipoDTO entity)
        {
            var model = await _context.Tbequipo.SingleOrDefaultAsync(x => x.IdEquipo == entity.IdEquipo);
            if (model == null)
                return false;
            _context.Tbequipo.Remove(model);
            int query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Exists(EquipoDTO entity)
        {
            return await _context.Tbequipo.AnyAsync(e => e.IdEquipo == entity.IdEquipo);
        }

        public async Task<IEnumerable<EquipoDTO>> Get()
        {
            return _mapper.Map<IEnumerable<EquipoDTO>>(await _context.Tbequipo.ToListAsync());
        }

        public async Task<EquipoDTO> GetById(EquipoDTO entity)
        {
            var model = await _context.Tbequipo.Where(x => x.IdEquipo == entity.IdEquipo).FirstOrDefaultAsync();
            return _mapper.Map<EquipoDTO>(model);
        }

        public async Task<bool> Post(EquipoDTO entity)
        {
            var model = _mapper.Map<Tbequipo>(entity);
            _context.Tbequipo.Add(model);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Put(EquipoDTO entity)
        {
            _context.Entry(_mapper.Map<Tbequipo>(entity)).State = EntityState.Modified;
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }
    }
}
