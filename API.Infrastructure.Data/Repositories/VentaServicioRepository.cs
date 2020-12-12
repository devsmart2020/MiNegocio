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
    public class VentaServicioRepository : IVentaServicio<VentaServicioDTO>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;
        public VentaServicioRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Delete(VentaServicioDTO entity)
        {
            var model = await _context.Tbventaservicio.SingleOrDefaultAsync(x => x.IdVenta == entity.IdVenta);
            if (model == null)
                return false;
            _context.Tbventaservicio.Remove(model);
            int query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Exists(VentaServicioDTO entity)
        {
            return await _context.Tbventaservicio.AnyAsync(e => e.IdVenta == entity.IdVenta);
        }

        public async Task<IEnumerable<VentaServicioDTO>> Get()
        {
            return _mapper.Map<IEnumerable<VentaServicioDTO>>(await _context.Tbventaservicio.ToListAsync());
        }

        public async Task<VentaServicioDTO> GetById(VentaServicioDTO entity)
        {
            var model = await _context.Tbventaservicio.Where(x => x.IdVenta == entity.IdVenta).FirstOrDefaultAsync();
            return _mapper.Map<VentaServicioDTO>(model);
        }

        public async Task<bool> Post(VentaServicioDTO entity)
        {
            var model = _mapper.Map<Tbventaservicio>(entity);
            _context.Tbventaservicio.Add(model);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Put(VentaServicioDTO entity)
        {
            _context.Entry(_mapper.Map<Tbventaservicio>(entity)).State = EntityState.Modified;
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }
    }
}
