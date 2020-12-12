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
    public class EstadoOrdenService : IEstadoOrdenService<EstadoOrdenDTO>
    {
        private protected readonly string controllerName = Resources.EstadoOrdenController;
        private readonly IRestService<EstadoOrdenDTO> _service;
        public EstadoOrdenService()
        {
            _service = new RestService<EstadoOrdenDTO>();
        }
        public async Task<bool> Delete(EstadoOrdenDTO entity)
        {
            return await _service.Delete(entity);
        }

        public async Task<EstadoOrdenDTO> GetById(EstadoOrdenDTO entity)
        {
            return await _service.GetById(controllerName, entity);
        }

        public async Task<IEnumerable<EstadoOrdenDTO>> GetListEntity(EstadoOrdenDTO entity)
        {
            return await _service.GetListEntity(controllerName, entity);
        }

        public async Task<IEnumerable<EstadoOrdenDTO>> GetTs(bool isDbQuery, string dbPath, string jsonName)
        {
            if (isDbQuery)
            {
                return await _service.GetTs(controllerName);
            }
            else
            {
                var read = File.ReadAllText($"{dbPath}{jsonName}");
                return JsonConvert.DeserializeObject<IEnumerable<EstadoOrdenDTO>>(read);
            }
        }

        public async Task<bool> Post(EstadoOrdenDTO entity, bool isNewItem)
        {
            return await _service.Post(controllerName, entity, isNewItem);
        }
    }
}
