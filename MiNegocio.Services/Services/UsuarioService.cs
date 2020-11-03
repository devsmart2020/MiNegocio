using MiNegocio.Models.Models;
using MiNegocio.Services.Data;
using MiNegocio.Services.Properties;
using MiNegocio.Services.Services_interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiNegocio.Services.Services
{
    public class UsuarioService : IUsuarioService<Tbusuario>
    {
        private readonly IRestService<Tbusuario> _service;
        private readonly string controllerName = Resources.UsersController;

        public UsuarioService()
        {
            _service = new RestService<Tbusuario>();
        }

        public async Task<bool> Delete(Tbusuario entity)
        {
            return await _service.Delete(entity.DocId);
        }

        public async Task<Tbusuario> GetById(Tbusuario entity)
        {
            return await _service.GetById(controllerName, entity);
        }

        public async Task<IEnumerable<Tbusuario>> GetListEntity(Tbusuario entity)
        {
            return await _service.GetListEntity(controllerName, entity);
        }

        public async Task<IEnumerable<Tbusuario>> GetTecnicos()
        {
            return await _service.GetTs($"{controllerName}/GetTecnicos");
        }

        public async Task<IEnumerable<Tbusuario>> GetTs()
        {
            return await _service.GetTs(controllerName);
        }

        public async Task<bool> Post(Tbusuario entity, bool isNewItem)
        {
            return await _service.Post(controllerName, entity, isNewItem);
        }
    }
}
