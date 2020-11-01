using MiNegocio.Models.Models;
using MiNegocio.Services.Data;
using MiNegocio.Services.Properties;
using MiNegocio.Services.Services_interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiNegocio.Services.Services
{
    public class MarcaService : IMarcaService<Tbmarca>
    {
        private readonly string controllerName = Resources.MarcaController;
        private protected readonly IRestService<Tbmarca> _service;

        public MarcaService()
        {
            _service = new RestService<Tbmarca>();
        }

        public async Task<bool> Delete(Tbmarca entity)
        {
            return await _service.Delete(entity.IdMarca);
        }

        public async Task<Tbmarca> GetById(Tbmarca entity)
        {
            return await _service.GetById(controllerName, entity);
        }

        public async Task<IEnumerable<Tbmarca>> GetListEntity(Tbmarca entity)
        {
            return await _service.GetListEntity(controllerName, entity);
        }

        public async Task<IEnumerable<Tbmarca>> GetTs()
        {
            return await _service.GetTs(controllerName);
        }

        public async Task<bool> Post(Tbmarca entity, bool isNewItem)
        {
            return await _service.Post(controllerName, entity, isNewItem);
        }
    }
}
