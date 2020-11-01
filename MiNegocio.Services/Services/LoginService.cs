using MiNegocio.Models.Models;
using MiNegocio.Services.Data;
using MiNegocio.Services.Properties;
using MiNegocio.Services.Services_interfaces;
using System.Threading.Tasks;

namespace MiNegocio.Services.Services
{
    public class LoginService : ILoginService<Tbusuario>
    {
        private readonly IRestService<Tbusuario> _service;
        private readonly string controllerName = Resources.LoginController;

        public LoginService()
        {
            _service = new RestService<Tbusuario>();
        }

        public  async Task<Tbusuario>Login(Tbusuario entity)
        {
            return await _service.Login(controllerName, entity);
        }
    }
}
