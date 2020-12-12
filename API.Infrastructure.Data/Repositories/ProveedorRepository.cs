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
    public class ProveedorRepository : IProveedor<ProveedorDTO>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;
        public ProveedorRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Delete(ProveedorDTO entity)
        {
            var model = await _context.Tbproveedor.SingleOrDefaultAsync(x => x.IdProveedor == entity.IdProveedor);
            if (model == null)
                return false;
            _context.Tbproveedor.Remove(model);
            int query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Exists(ProveedorDTO entity)
        {
            return await _context.Tbproveedor.AnyAsync(e => e.IdProveedor == entity.IdProveedor);
        }

        public async Task<IEnumerable<ProveedorDTO>> Get()
        {
            return _mapper.Map<IEnumerable<ProveedorDTO>>(await _context.Tbproveedor.ToListAsync());
        }

        public async Task<ProveedorDTO> GetById(ProveedorDTO entity)
        {
            var model = await _context.Tbproveedor.Where(x => x.IdProveedor == entity.IdProveedor).FirstOrDefaultAsync();
            return _mapper.Map<ProveedorDTO>(model);
        }

        public async Task<bool> Post(ProveedorDTO entity)
        {
            var model = _mapper.Map<Tbproveedor>(entity);
            _context.Tbproveedor.Add(model);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Put(ProveedorDTO entity)
        {
            _context.Entry(_mapper.Map<Tbproveedor>(entity)).State = EntityState.Modified;
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }
    }
}
