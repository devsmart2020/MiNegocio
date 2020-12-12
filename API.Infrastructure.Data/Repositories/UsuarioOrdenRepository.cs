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
    public class UsuarioOrdenRepository : IUsuarioOrden<UsuarioOrdenDTO>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;
        public UsuarioOrdenRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Delete(UsuarioOrdenDTO entity)
        {
            var model = await _context.Tbusuarioorden.SingleOrDefaultAsync(x => x.IdOrden == entity.IdOrden);
            if (model == null)
                return false;
            _context.Tbusuarioorden.Remove(model);
            int query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Exists(UsuarioOrdenDTO entity)
        {
            return await _context.Tbusuarioorden.AnyAsync(e => e.IdOrden == entity.IdOrden);
        }

        public async Task<IEnumerable<UsuarioOrdenDTO>> Get()
        {
            return _mapper.Map<IEnumerable<UsuarioOrdenDTO>>(await _context.Tbusuarioorden.ToListAsync());
        }

        public async Task<UsuarioOrdenDTO> GetById(UsuarioOrdenDTO entity)
        {
            var model = await _context.Tbusuarioorden.Where(x => x.IdOrden == entity.IdOrden).FirstOrDefaultAsync();
            return _mapper.Map<UsuarioOrdenDTO>(model);
        }

        public async Task<bool> Post(UsuarioOrdenDTO entity)
        {
            var model = _mapper.Map<Tbusuarioorden>(entity);
            _context.Tbusuarioorden.Add(model);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Put(UsuarioOrdenDTO entity)
        {
            _context.Entry(_mapper.Map<Tbusuarioorden>(entity)).State = EntityState.Modified;
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }
    }
}
