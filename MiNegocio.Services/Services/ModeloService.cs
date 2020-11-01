using MiNegocio.Models.Models;
using MiNegocio.Services.Data;
using MiNegocio.Services.Properties;
using MiNegocio.Services.Services_interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiNegocio.Services.Services
{
    public class ModeloService : IModeloService<Tbmodelo>
    {
        private readonly string controllerName = Resources.ModelController;
        private protected readonly IRestService<Tbmodelo> _service;
        public ModeloService()
        {
            _service = new RestService<Tbmodelo>();
        }

        public async Task<bool> Delete(Tbmodelo entity)
        {
            return await _service.Delete(entity.IdModelo);
        }

        public async Task<Tbmodelo> GetById(Tbmodelo entity)
        {
            return await _service.GetById(controllerName, entity);
        }

        public async Task<IEnumerable<Tbmodelo>> GetListEntity(Tbmodelo entity)
        {
            return await _service.GetListEntity(controllerName, entity);
        }

        public async Task<IEnumerable<Tbmodelo>> GetTs()
        {
            return await _service.GetTs(controllerName);
        }

        public async Task<bool> Post(Tbmodelo entity, bool isNewItem)
        {
            return await _service.Post(controllerName, entity, isNewItem);
        }
    }
}
