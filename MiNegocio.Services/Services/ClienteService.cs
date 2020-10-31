using MiNegocio.Models.Models;
using MiNegocio.Services.Data;
using MiNegocio.Services.Properties;
using MiNegocio.Services.Services_interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiNegocio.Services.Services
{
    public class ClienteService : IClienteService<Tbcliente>
    {
        private readonly string controllerName = Resources.ClienteController;
        private protected readonly IRestService<Tbcliente> _service;
        public ClienteService()
        {
            _service = new RestService<Tbcliente>();
        }

        public async Task<bool> Delete(Tbcliente entity)
        {
            return await _service.Delete(entity.DocId);
        }

        public async Task<Tbcliente> GetById(Tbcliente entity)
        {
            return await _service.GetById(controllerName, entity);
        }

        public async Task<IEnumerable<Tbcliente>> GetListEntity(Tbcliente entity)
        {
            return await _service.GetListEntity(controllerName, entity);
        }

        public async Task<IEnumerable<Tbcliente>> GetTs()
        {
            return await _service.GetTs(controllerName);
        }

        public async Task<bool> Post(Tbcliente entity, bool isNewItem)
        {
            return await _service.Post(controllerName,entity, isNewItem);
        }
    }
}
