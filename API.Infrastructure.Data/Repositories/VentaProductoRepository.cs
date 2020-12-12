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
    public class VentaProductoRepository : IVentaProducto<VentaProductoDTO>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;
        public VentaProductoRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Delete(VentaProductoDTO entity)
        {
            var model = await _context.Tbventaproducto.SingleOrDefaultAsync(x => x.IdVenta == entity.IdVenta);
            if (model == null)
                return false;
            _context.Tbventaproducto.Remove(model);
            int query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Exists(VentaProductoDTO entity)
        {
            return await _context.Tbventaproducto.AnyAsync(e => e.IdVenta == entity.IdVenta);
        }

        public async Task<IEnumerable<VentaProductoDTO>> Get()
        {
            return _mapper.Map<IEnumerable<VentaProductoDTO>>(await _context.Tbventaproducto.ToListAsync());
        }

        public async Task<VentaProductoDTO> GetById(VentaProductoDTO entity)
        {
            var model = await _context.Tbventaproducto.Where(x => x.IdVenta == entity.IdVenta).FirstOrDefaultAsync();
            return _mapper.Map<VentaProductoDTO>(model);
        }

        public async Task<bool> Post(VentaProductoDTO entity)
        {
            var model = _mapper.Map<Tbventaproducto>(entity);
            _context.Tbventaproducto.Add(model);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Put(VentaProductoDTO entity)
        {
            _context.Entry(_mapper.Map<Tbventaproducto>(entity)).State = EntityState.Modified;
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }
    }
}
