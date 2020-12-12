using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class LoginRepository : ILogin<UsuarioDTO>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;

        public LoginRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<UsuarioDTO> GetUsuario(UsuarioDTO entity)
        {
            var model = await _context.Tbusuario.Where(x => x.User.Equals(entity.User) && x.Pass.Equals(entity.Pass)).FirstOrDefaultAsync();
            return _mapper.Map<UsuarioDTO>(model);
        }
    }
}
