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
    public class OrdenRepository : IOrden<OrdenDTO>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;
        public OrdenRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Delete(OrdenDTO entity)
        {
            var model = await _context.Tborden.SingleOrDefaultAsync(x => x.IdOrden == entity.IdOrden);
            if (model == null)
                return false;
            _context.Tborden.Remove(model);
            int query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Exists(OrdenDTO entity)
        {
            return await _context.Tborden.AnyAsync(e => e.IdOrden == entity.IdOrden);
        }

        public async Task<IEnumerable<OrdenDTO>> Get()
        {
            return _mapper.Map<IEnumerable<OrdenDTO>>(await _context.Tborden.ToListAsync());
        }

        public async Task<OrdenDTO> GetById(OrdenDTO entity)
        {
            var model = await _context.Tborden.Where(x => x.IdOrden == entity.IdOrden).FirstOrDefaultAsync();
            return _mapper.Map<OrdenDTO>(model);
        }

        public async Task<bool> Post(OrdenDTO entity)
        {
            var model = _mapper.Map<Tborden>(entity);
            _context.Tborden.Add(model);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Put(OrdenDTO entity)
        {
            _context.Entry(_mapper.Map<Tborden>(entity)).State = EntityState.Modified;
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }
    }
}
