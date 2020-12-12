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
    public class CompraRepository : ICompra<CompraDTO>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;

        public CompraRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> Delete(CompraDTO entity)
        {
            var model = await _context.Tbcompra.SingleOrDefaultAsync(x => x.IdCompra == entity.IdCompra);
            if (model == null)
                return false;
            _context.Tbcompra.Remove(model);
            int query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Exists(CompraDTO entity)
        {
            return await _context.Tbcompra.AnyAsync(e => e.IdCompra == entity.IdCompra);
        }

        public async Task<IEnumerable<CompraDTO>> Get()
        {
            return _mapper.Map<IEnumerable<CompraDTO>>(await _context.Tbcompra.ToListAsync());
        }

        public async Task<CompraDTO> GetById(CompraDTO entity)
        {
            var model = await _context.Tbcompra.Where(x => x.IdCompra == entity.IdCompra).FirstOrDefaultAsync();
            return _mapper.Map<CompraDTO>(model);
        }

        public async Task<bool> Post(CompraDTO entity)
        {
            var model = _mapper.Map<Tbcompra>(entity);
            _context.Tbcompra.Add(model);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Put(CompraDTO entity)
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
