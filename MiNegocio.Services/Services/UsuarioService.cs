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
        private readonly IRestService<Tbusuario> _service;
        private readonly string controllerName = Resources.UsersController;

        public UsuarioService()
        {
            _service = new RestService<Tbusuario>();
        }

        public Task<bool> Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Tbusuario> GetById(Tbusuario entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Tbusuario>> GetListEntity( Tbusuario entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Tbusuario>> GetTs()
        {
            throw new NotImplementedException();
        }     

        public Task<bool> Post(Tbusuario entity, bool isNewItem)
        {
            throw new NotImplementedException();
        }
    }
}
