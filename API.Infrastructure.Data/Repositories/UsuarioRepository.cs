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
    public class UsuarioRepository : IUsuario<UsuarioDTO>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;
        public UsuarioRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Delete(UsuarioDTO entity)
        {
            var model = await _context.Tbusuario.SingleOrDefaultAsync(x => x.DocId == entity.DocId);
            if (model == null)
                return false;
            _context.Tbusuario.Remove(model);
            int query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Exists(UsuarioDTO entity)
        {
            return await _context.Tbusuario.AnyAsync(e => e.DocId == entity.DocId);
        }

        public async Task<IEnumerable<UsuarioDTO>> Get()
        {
            return _mapper.Map<IEnumerable<UsuarioDTO>>(await _context.Tbusuario.ToListAsync());
        }

        public async Task<UsuarioDTO> GetById(UsuarioDTO entity)
        {
            var model = await _context.Tbusuario.Where(x => x.DocId == entity.DocId).FirstOrDefaultAsync();
            return _mapper.Map<UsuarioDTO>(model);
        }

        public async Task<IEnumerable<UsuarioDTO>> GetTecnicos()
        {
            var model = await _context.Tbusuario
                .Where(x => x.IdPerfilNavigation.Perfil.Equals("TÉCNICO")).Select(t => new UsuarioDTO
                {
                    DocId = t.DocId,
                    Nombres = t.Nombres,
                    Apellidos = t.Apellidos,
                    NomCompleto = $"{t.Nombres} {t.Apellidos}",
                    Direccion = t.Direccion,
                    Telefono = t.Telefono,
                    User = t.User,
                    IdPerfil = t.IdPerfil,
                    Estado = t.Estado
                }).ToListAsync();
            return _mapper.Map<IEnumerable<UsuarioDTO>>(model);
        }

        public async Task<bool> Post(UsuarioDTO entity)
        {
            var model = _mapper.Map<Tbusuario>(entity);
            _context.Tbusuario.Add(model);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Put(UsuarioDTO entity)
        {
            _context.Entry(_mapper.Map<Tbusuario>(entity)).State = EntityState.Modified;
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }
    }
}
