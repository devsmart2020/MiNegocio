using MiNegocio.Models.Models;
using MiNegocio.Services.Data;
using MiNegocio.Services.Properties;
using MiNegocio.Services.Services_interfaces;
using System.Threading.Tasks;

namespace MiNegocio.Services.Services
{
    public class LoginService : ILoginService<UsuarioDTO>
    {
        private readonly IRestService<UsuarioDTO> _service;
        private readonly string controllerName = Resources.LoginController;

        public LoginService()
        {
            _service = new RestService<UsuarioDTO>();
        }

        public  async Task<UsuarioDTO>Login(UsuarioDTO entity)
        {
            return await _service.Login(controllerName, entity);
        }
    }
}
