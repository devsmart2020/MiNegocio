using MiNegocio.Models.Models;
using MiNegocio.Services.Data;
using MiNegocio.Services.Properties;
using MiNegocio.Services.Services_interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiNegocio.Services.Services
{
    public class EstadoOrdenService : IEstadoOrdenService<Tbestadoorden>
    {
        private protected readonly string controllerName = Resources.EstadoOrdenController;
        private readonly IRestService<Tbestadoorden> _service;
        public EstadoOrdenService()
        {
            _service = new RestService<Tbestadoorden>();
        }
        public async Task<bool> Delete(Tbestadoorden entity)
        {
            return await _service.Delete(entity);
        }

        public async Task<Tbestadoorden> GetById(Tbestadoorden entity)
        {
            return await _service.GetById(controllerName, entity);
        }

        public async Task<IEnumerable<Tbestadoorden>> GetListEntity(Tbestadoorden entity)
        {
            return await _service.GetListEntity(controllerName, entity);
        }

        public async Task<IEnumerable<Tbestadoorden>> GetTs()
        {
            return await _service.GetTs(controllerName);
        }

        public async Task<bool> Post(Tbestadoorden entity, bool isNewItem)
        {
            return await _service.Post(controllerName, entity, isNewItem);
        }
    }
}
