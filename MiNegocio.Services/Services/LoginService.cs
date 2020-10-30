using MiNegocio.Models.Models;
using MiNegocio.Services.Data;
using MiNegocio.Services.Properties;
using System.Threading.Tasks;

namespace MiNegocio.Services.Services
{
    public class LoginService
    {
        private readonly IRestService<TbUsuario> _service;
        private readonly string controllerName = Resources.LoginController;

        public LoginService()
        {
            _service = new RestService<TbUsuario>();
        }

        public  async Task<TbUsuario>Login(TbUsuario entity)
        {
            return await _service.Login(controllerName, entity);
        }
    }
}
