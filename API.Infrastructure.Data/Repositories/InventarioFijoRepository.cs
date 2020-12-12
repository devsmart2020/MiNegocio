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
    public class InventarioFijoRepository : IInventarioFijo<InventarioFijoDTO>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;

        public InventarioFijoRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Delete(InventarioFijoDTO entity)
        {
            var model = await _context.Tbinventariofijo.SingleOrDefaultAsync(x => x.IdProducto == entity.IdProducto);
            if (model == null)
                return false;
            _context.Tbinventariofijo.Remove(model);
            int query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Exists(InventarioFijoDTO entity)
        {
            return await _context.Tbinventariofijo.AnyAsync(e => e.IdProducto == entity.IdProducto);
        }

        public async Task<IEnumerable<InventarioFijoDTO>> Get()
        {
            return _mapper.Map<IEnumerable<InventarioFijoDTO>>(await _context.Tbinventariofijo.ToListAsync());
        }

        public async Task<InventarioFijoDTO> GetById(InventarioFijoDTO entity)
        {
            var model = await _context.Tbinventariofijo.Where(x => x.IdProducto == entity.IdProducto).FirstOrDefaultAsync();
            return _mapper.Map<InventarioFijoDTO>(model);
        }

        public async Task<bool> Post(InventarioFijoDTO entity)
        {
            var model = _mapper.Map<Tbinventariofijo>(entity);
            _context.Tbinventariofijo.Add(model);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Put(InventarioFijoDTO entity)
        {
            _context.Entry(_mapper.Map<Tbinventariofijo>(entity)).State = EntityState.Modified;
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }
    }
}
