using MiNegocio.Models.Models;
using MiNegocio.Services.Data;
using MiNegocio.Services.Properties;
using MiNegocio.Services.Services_interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace MiNegocio.Services.Services
{
    public class ClienteService : IClienteService<ClienteDTO>
    {
        private readonly string controllerName = Resources.ClienteController;
        private protected readonly IRestService<ClienteDTO> _service;
        public ClienteService()
        {
            _service = new RestService<ClienteDTO>();
        }

        public async Task<bool> Delete(ClienteDTO entity)
        {
            return await _service.Delete(entity.DocId);
        }

        public async Task<ClienteDTO> GetById(ClienteDTO entity)
        {
            return await _service.GetById(controllerName, entity);
        }

        public async Task<IEnumerable<ClienteDTO>> GetListEntity(ClienteDTO entity)
        {
            return await _service.GetListEntity(controllerName, entity);
        }

        public async Task<IEnumerable<ClienteDTO>> GetTs(bool isDbQuery, string dbPath, string jsonName)
        {
            if (isDbQuery)
            {
                return await _service.GetTs(controllerName);
            }
            else
            {
                var read = File.ReadAllText($"{dbPath}{jsonName}");
                return JsonConvert.DeserializeObject<IEnumerable<ClienteDTO>>(read);
            }
        }

        public async Task<bool> Post(ClienteDTO entity, bool isNewItem)
        {
            return await _service.Post(controllerName, entity, isNewItem);
        }

        public async Task<IEnumerable<ClienteDTO>> RptEquiposxCliente(ClienteDTO entity)
        {
            return await _service.GetListEntity($"{controllerName}/RptEquipoCliente", entity);
        }

        public async Task<IEnumerable<ClienteDTO>> RptOrdenxCliente(ClienteDTO entity)
        {
            return await _service.GetListEntity($"{controllerName}/RptOrdenCliente", entity);
        }
    }
}
