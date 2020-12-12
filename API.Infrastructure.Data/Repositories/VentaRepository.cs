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
    public class VentaRepository : IVenta<VentaDTO>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;
        public VentaRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Delete(VentaDTO entity)
        {
            var model = await _context.Tbventa.SingleOrDefaultAsync(x => x.IdVenta == entity.IdVenta);
            if (model == null)
                return false;
            _context.Tbventa.Remove(model);
            int query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Exists(VentaDTO entity)
        {
            return await _context.Tbventa.AnyAsync(e => e.IdVenta == entity.IdVenta);
        }

        public async Task<IEnumerable<VentaDTO>> Get()
        {
            return _mapper.Map<IEnumerable<VentaDTO>>(await _context.Tbventa.ToListAsync());
        }

        public async Task<VentaDTO> GetById(VentaDTO entity)
        {
            var model = await _context.Tbventa.Where(x => x.IdVenta == entity.IdVenta).FirstOrDefaultAsync();
            return _mapper.Map<VentaDTO>(model);
        }

        public async Task<bool> Post(VentaDTO entity)
        {
            var model = _mapper.Map<Tbventa>(entity);
            _context.Tbventa.Add(model);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Put(VentaDTO entity)
        {
            _context.Entry(_mapper.Map<Tbventa>(entity)).State = EntityState.Modified;
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }
    }
}
