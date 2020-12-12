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
    public class VentaProductoAnuladaRepository : IVentaProductoAnulada<VentaProductoAnuladaDTO>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;
        public VentaProductoAnuladaRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Delete(VentaProductoAnuladaDTO entity)
        {
            var model = await _context.Tbventaproductoanulada.SingleOrDefaultAsync(x => x.IdVenta == entity.IdVenta);
            if (model == null)
                return false;
            _context.Tbventaproductoanulada.Remove(model);
            int query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Exists(VentaProductoAnuladaDTO entity)
        {
            return await _context.Tbventaproductoanulada.AnyAsync(e => e.IdVenta == entity.IdVenta);
        }

        public async Task<IEnumerable<VentaProductoAnuladaDTO>> Get()
        {
            return _mapper.Map<IEnumerable<VentaProductoAnuladaDTO>>(await _context.Tbventaproductoanulada.ToListAsync());
        }

        public async Task<VentaProductoAnuladaDTO> GetById(VentaProductoAnuladaDTO entity)
        {
            var model = await _context.Tbventaproductoanulada.Where(x => x.IdVenta == entity.IdVenta).FirstOrDefaultAsync();
            return _mapper.Map<VentaProductoAnuladaDTO>(model);
        }

        public async Task<bool> Post(VentaProductoAnuladaDTO entity)
        {
            var model = _mapper.Map<Tbventaproductoanulada>(entity);
            _context.Tbventaproductoanulada.Add(model);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Put(VentaProductoAnuladaDTO entity)
        {
            _context.Entry(_mapper.Map<Tbventaproductoanulada>(entity)).State = EntityState.Modified;
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }
    }
}
