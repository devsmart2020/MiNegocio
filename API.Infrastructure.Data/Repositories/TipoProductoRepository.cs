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
    public class TipoProductoRepository : ITipoProducto<TipoProductoDTO>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;
        public TipoProductoRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Delete(TipoProductoDTO entity)
        {
            var model = await _context.Tbtipoproducto.SingleOrDefaultAsync(x => x.IdTipoProducto == entity.IdTipoProducto);
            if (model == null)
                return false;
            _context.Tbtipoproducto.Remove(model);
            int query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Exists(TipoProductoDTO entity)
        {
            return await _context.Tbtipoproducto.AnyAsync(e => e.IdTipoProducto == entity.IdTipoProducto);
        }

        public async Task<IEnumerable<TipoProductoDTO>> Get()
        {
            return _mapper.Map<IEnumerable<TipoProductoDTO>>(await _context.Tbtipoproducto.ToListAsync());
        }

        public async Task<TipoProductoDTO> GetById(TipoProductoDTO entity)
        {
            var model = await _context.Tbtipoproducto.Where(x => x.IdTipoProducto == entity.IdTipoProducto).FirstOrDefaultAsync();
            return _mapper.Map<TipoProductoDTO>(model);
        }

        public async Task<bool> Post(TipoProductoDTO entity)
        {
            var model = _mapper.Map<Tbtipoproducto>(entity);
            _context.Tbtipoproducto.Add(model);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Put(TipoProductoDTO entity)
        {
            _context.Entry(_mapper.Map<Tbtipoproducto>(entity)).State = EntityState.Modified;
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }
    }
}
