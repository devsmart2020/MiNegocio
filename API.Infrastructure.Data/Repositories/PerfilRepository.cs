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
    public class PerfilRepository : IPerfil<PerfilDTO>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;
        public PerfilRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Delete(PerfilDTO entity)
        {
            var model = await _context.Tbperfil.SingleOrDefaultAsync(x => x.IdPerfil == entity.IdPerfil);
            if (model == null)
                return false;
            _context.Tbperfil.Remove(model);
            int query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Exists(PerfilDTO entity)
        {
            return await _context.Tbperfil.AnyAsync(e => e.IdPerfil == entity.IdPerfil);
        }

        public async Task<IEnumerable<PerfilDTO>> Get()
        {
            return _mapper.Map<IEnumerable<PerfilDTO>>(await _context.Tbperfil.ToListAsync());
        }

        public async Task<PerfilDTO> GetById(PerfilDTO entity)
        {
            var model = await _context.Tbperfil.Where(x => x.IdPerfil == entity.IdPerfil).FirstOrDefaultAsync();
            return _mapper.Map<PerfilDTO>(model);
        }

        public async Task<bool> Post(PerfilDTO entity)
        {
            var model = _mapper.Map<Tbperfil>(entity);
            _context.Tbperfil.Add(model);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Put(PerfilDTO entity)
        {
            _context.Entry(_mapper.Map<Tbperfil>(entity)).State = EntityState.Modified;
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }
    }
}
