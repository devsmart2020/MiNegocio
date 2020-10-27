using MiNegocio.Models.Models;
using MiNegocio.Services.Data;
using MiNegocio.Services.Properties;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiNegocio.Services.Services
{
    public class UsuarioService
    {
        private readonly IRestService<TbUsuario> _service;
        private readonly string controllerName = Resources.UsersController;

        public UsuarioService()
        {
            _service = new RestService<TbUsuario>();
        }

        public Task<bool> Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<TbUsuario> GetById(TbUsuario entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TbUsuario>> GetListEntity( TbUsuario entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TbUsuario>> GetTs()
        {
            throw new NotImplementedException();
        }

        public async Task<TbUsuario> Login(TbUsuario entity)
        {
            return await _service.Login(controllerName, entity);
        }

        public Task<bool> Post(TbUsuario entity, bool isNewItem)
        {
            throw new NotImplementedException();
        }
    }
}
