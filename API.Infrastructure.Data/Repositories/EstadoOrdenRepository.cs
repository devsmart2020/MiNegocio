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

    public class EstadoOrdenRepository : IEstadoOrden<EstadoOrdenDTO>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;

        public EstadoOrdenRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Delete(EstadoOrdenDTO entity)
        {
            var model = await _context.Tbestadoorden.SingleOrDefaultAsync(x => x.IdEstadoOrden == entity.IdEstadoOrden);
            if (model == null)
                return false;
            _context.Tbestadoorden.Remove(model);
            int query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Exists(EstadoOrdenDTO entity)
        {
            return await _context.Tbestadoorden.AnyAsync(e => e.IdEstadoOrden == entity.IdEstadoOrden);
        }

        public async Task<IEnumerable<EstadoOrdenDTO>> Get()
        {
            return _mapper.Map<IEnumerable<EstadoOrdenDTO>>(await _context.Tbestadoorden.ToListAsync());
        }

        public async Task<EstadoOrdenDTO> GetById(EstadoOrdenDTO entity)
        {
            var model = await _context.Tbestadoorden.Where(x => x.IdEstadoOrden == entity.IdEstadoOrden).FirstOrDefaultAsync();
            return _mapper.Map<EstadoOrdenDTO>(model);
        }

        public async Task<bool> Post(EstadoOrdenDTO entity)
        {
            var model = _mapper.Map<Tbestadoorden>(entity);
            _context.Tbestadoorden.Add(model);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Put(EstadoOrdenDTO entity)
        {
            _context.Entry(_mapper.Map<Tbestadoorden>(entity)).State = EntityState.Modified;
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

    }
}
