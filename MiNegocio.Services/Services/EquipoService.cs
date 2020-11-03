using MiNegocio.Models.Models;
using MiNegocio.Services.Data;
using MiNegocio.Services.Properties;
using MiNegocio.Services.Services_interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiNegocio.Services.Services
{
    public class EquipoService : IEquipoService<Tbequipo>
    {
        private readonly string controllerName = Resources.EquipoController;
        private protected readonly IRestService<Tbequipo> _service;
        public EquipoService()
        {
            _service = new RestService<Tbequipo>();
        }

        public async Task<bool> Delete(Tbequipo entity)
        {
            return await _service.Delete(entity);
        }

        public async Task<Tbequipo> GetById(Tbequipo entity)
        {
            return await _service.GetById(controllerName, entity);
        }

        public async Task<IEnumerable<Tbequipo>> GetListEntity(Tbequipo entity)
        {
            return await _service.GetListEntity(controllerName, entity);
        }

        public async Task<IEnumerable<Tbequipo>> GetTs()
        {
            return await _service.GetTs(controllerName);
        }

        public async Task<bool> Post(Tbequipo entity, bool isNewItem)
        {
            return await _service.Post(controllerName, entity, isNewItem);
        }
    }
}
