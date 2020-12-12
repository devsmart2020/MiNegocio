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
    public class ProductoSerialRepository : IProductoSerial<ProductoSerialDTO>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;
        public ProductoSerialRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Delete(ProductoSerialDTO entity)
        {
            var model = await _context.Tbproductoserial.SingleOrDefaultAsync(x => x.IdProducto == entity.IdProducto);
            if (model == null)
                return false;
            _context.Tbproductoserial.Remove(model);
            int query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Exists(ProductoSerialDTO entity)
        {
            return await _context.Tbproductoserial.AnyAsync(e => e.IdProducto == entity.IdProducto);
        }

        public async Task<IEnumerable<ProductoSerialDTO>> Get()
        {
            return _mapper.Map<IEnumerable<ProductoSerialDTO>>(await _context.Tbproductoserial.ToListAsync());
        }

        public async Task<ProductoSerialDTO> GetById(ProductoSerialDTO entity)
        {
            var model = await _context.Tbproductoserial.Where(x => x.IdProducto == entity.IdProducto).FirstOrDefaultAsync();
            return _mapper.Map<ProductoSerialDTO>(model);
        }

        public async Task<bool> Post(ProductoSerialDTO entity)
        {
            var model = _mapper.Map<Tbproductoserial>(entity);
            _context.Tbproductoserial.Add(model);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Put(ProductoSerialDTO entity)
        {
            _context.Entry(_mapper.Map<Tbproductoserial>(entity)).State = EntityState.Modified;
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }
    }
}
