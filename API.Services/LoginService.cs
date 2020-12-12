using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Threading.Tasks;

namespace API.Services
{
    public class LoginService : ILoginService<UsuarioDTO>
    {
        private readonly ILogin<UsuarioDTO> _repository;

        public LoginService(ILogin<UsuarioDTO> repository)
        {
            _repository = repository;
        }

        public async Task<UsuarioDTO> GetUsuario(UsuarioDTO entity)
        {
            return await _repository.GetUsuario(entity);
        }
    }
}
