using MiNegocio.Models.Models;
using MiNegocio.Services.Data;
using MiNegocio.Services.Properties;
using MiNegocio.Services.Services_interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiNegocio.Services.Services
{
    public class PerfilService : IPerfilService<Tbperfil>
    {
        private protected readonly string controllerName = Resources.PerfilController;
        private readonly IRestService<Tbperfil> _service;

        public PerfilService()
        {
            _service = new RestService<Tbperfil>();
        }

        public async Task<bool> Delete(Tbperfil entity)
        {
            return await _service.Delete(entity.IdPerfil);
        }

        public async Task<Tbperfil> GetById(Tbperfil entity)
        {
            return await _service.GetById(controllerName, entity);
        }

        public async Task<IEnumerable<Tbperfil>> GetListEntity(Tbperfil entity)
        {
            return await _service.GetListEntity(controllerName, entity);
        }

        public async Task<IEnumerable<Tbperfil>> GetTs()
        {
            return await _service.GetTs(controllerName);
        }

        public async Task<bool> Post(Tbperfil entity, bool isNewItem)
        {
            return await _service.Post(controllerName, entity, isNewItem);
        }
    }
}
