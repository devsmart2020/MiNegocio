using MiNegocio.Models.Models;
using MiNegocio.Services.Data;
using MiNegocio.Services.Properties;
using MiNegocio.Services.Services_interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiNegocio.Services.Services
{
    public class PerfilService : IPerfilService<PerfilDTO>
    {
        private protected readonly string controllerName = Resources.PerfilController;
        private readonly IRestService<PerfilDTO> _service;

        public PerfilService()
        {
            _service = new RestService<PerfilDTO>();
        }

        public async Task<bool> Delete(PerfilDTO entity)
        {
            return await _service.Delete(entity.IdPerfil);
        }

        public async Task<PerfilDTO> GetById(PerfilDTO entity)
        {
            return await _service.GetById(controllerName, entity);
        }

        public async Task<IEnumerable<PerfilDTO>> GetListEntity(PerfilDTO entity)
        {
            return await _service.GetListEntity(controllerName, entity);
        }

        public async Task<IEnumerable<PerfilDTO>> GetTs()
        {
            return await _service.GetTs(controllerName);
        }

        public async Task<bool> Post(PerfilDTO entity, bool isNewItem)
        {
            return await _service.Post(controllerName, entity, isNewItem);
        }
    }
}
