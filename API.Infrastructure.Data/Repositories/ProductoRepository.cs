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
    public class ProductoRepository : IProducto<ProductoDTO>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;
        public ProductoRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Delete(ProductoDTO entity)
        {
            var model = await _context.Tbproducto.SingleOrDefaultAsync(x => x.IdProducto == entity.IdProducto);
            if (model == null)
                return false;
            _context.Tbproducto.Remove(model);
            int query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Exists(ProductoDTO entity)
        {
            return await _context.Tbproducto.AnyAsync(e => e.IdProducto == entity.IdProducto);
        }

        public async Task<IEnumerable<ProductoDTO>> Get()
        {
            return _mapper.Map<IEnumerable<ProductoDTO>>(await _context.Tbproducto.ToListAsync());
        }

        public async Task<ProductoDTO> GetById(ProductoDTO entity)
        {
            var model = await _context.Tbproducto.Where(x => x.IdProducto == entity.IdProducto).FirstOrDefaultAsync();
            return _mapper.Map<ProductoDTO>(model);
        }

        public async Task<bool> Post(ProductoDTO entity)
        {
            var model = _mapper.Map<Tbproducto>(entity);
            _context.Tbproducto.Add(model);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Put(ProductoDTO entity)
        {
            _context.Entry(_mapper.Map<Tbproducto>(entity)).State = EntityState.Modified;
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }
    }
}
