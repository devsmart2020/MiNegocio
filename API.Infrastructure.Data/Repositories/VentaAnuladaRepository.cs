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
    public class VentaAnuladaRepository : IVentaAnulada<VentaAnuladaDTO>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;
        public VentaAnuladaRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Delete(VentaAnuladaDTO entity)
        {
            var model = await _context.Tbventaanulada.SingleOrDefaultAsync(x => x.IdVenta == entity.IdVenta);
            if (model == null)
                return false;
            _context.Tbventaanulada.Remove(model);
            int query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Exists(VentaAnuladaDTO entity)
        {
            return await _context.Tbventaanulada.AnyAsync(e => e.IdVenta == entity.IdVenta);
        }

        public async Task<IEnumerable<VentaAnuladaDTO>> Get()
        {
            return _mapper.Map<IEnumerable<VentaAnuladaDTO>>(await _context.Tbventaanulada.ToListAsync());
        }

        public async Task<VentaAnuladaDTO> GetById(VentaAnuladaDTO entity)
        {
            var model = await _context.Tbventaanulada.Where(x => x.IdVenta == entity.IdVenta).FirstOrDefaultAsync();
            return _mapper.Map<VentaAnuladaDTO>(model);
        }

        public async Task<bool> Post(VentaAnuladaDTO entity)
        {
            var model = _mapper.Map<Tbventaanulada>(entity);
            _context.Tbventaanulada.Add(model);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Put(VentaAnuladaDTO entity)
        {
            _context.Entry(_mapper.Map<Tbventaanulada>(entity)).State = EntityState.Modified;
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }
    }
}
