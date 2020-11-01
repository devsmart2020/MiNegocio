using MiNegocio.Models.Models;
using MiNegocio.Services.Data;
using MiNegocio.Services.Properties;
using MiNegocio.Services.Services_interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiNegocio.Services.Services
{
    public class TipoEquipoService : ITipoEquipoService<Tbtipoequipo>
    {
        private readonly string controllerName = Resources.TipoEquipoController;
        private protected readonly IRestService<Tbtipoequipo> _service;

        public TipoEquipoService()
        {
            _service = new RestService<Tbtipoequipo>();    
        }

        public async Task<bool> Delete(Tbtipoequipo entity)
        {
            return await _service.Delete(entity.IdTipoEquipo);
        }

        public async Task<Tbtipoequipo> GetById(Tbtipoequipo entity)
        {
            return await _service.GetById(controllerName, entity);
        }

        public async Task<IEnumerable<Tbtipoequipo>> GetListEntity(Tbtipoequipo entity)
        {
            return await _service.GetListEntity(controllerName, entity);
        }

        public async Task<IEnumerable<Tbtipoequipo>> GetTs()
        {
            return await _service.GetTs(controllerName);
        }

        public async Task<bool> Post(Tbtipoequipo entity, bool isNewItem)
        {
            return await _service.Post(controllerName, entity, isNewItem);
        }
    }
}
