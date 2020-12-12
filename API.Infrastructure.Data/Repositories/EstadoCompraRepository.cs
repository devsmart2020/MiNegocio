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
    public class EstadoCompraRepository : IEstadoCompra<EstadoCompraDTO>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;

        public EstadoCompraRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> Delete(EstadoCompraDTO entity)
        {
            var model = await _context.Tbcompra.SingleOrDefaultAsync(x => x.IdEstadoCompra == entity.IdEstadoCompra);
            if (model == null)
                return false;
            _context.Tbcompra.Remove(model);
            int query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Exists(EstadoCompraDTO entity)
        {
            return await _context.Tbcompra.AnyAsync(e => e.IdEstadoCompra == entity.IdEstadoCompra);
        }

        public async Task<IEnumerable<EstadoCompraDTO>> Get()
        {
            return _mapper.Map<IEnumerable<EstadoCompraDTO>>(await _context.Tbcompra.ToListAsync());
        }

        public async Task<EstadoCompraDTO> GetById(EstadoCompraDTO entity)
        {
            var model = await _context.Tbcompra.Where(x => x.IdEstadoCompra == entity.IdEstadoCompra).FirstOrDefaultAsync();
            return _mapper.Map<EstadoCompraDTO>(model);
        }

        public async Task<bool> Post(EstadoCompraDTO entity)
        {
            var model = _mapper.Map<Tbcompra>(entity);
            _context.Tbcompra.Add(model);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Put(EstadoCompraDTO entity)
        {
            _context.Entry(_mapper.Map<Tbcompra>(entity)).State = EntityState.Modified;
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }
    }
}
