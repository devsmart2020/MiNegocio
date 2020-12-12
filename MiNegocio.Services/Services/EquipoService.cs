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
    public class EquipoService : IEquipoService<EquipoDTO>
    {
        private readonly string controllerName = Resources.EquipoController;
        private protected readonly IRestService<EquipoDTO> _service;
        public EquipoService()
        {
            _service = new RestService<EquipoDTO>();
        }

        public async Task<bool> Delete(EquipoDTO entity)
        {
            return await _service.Delete(entity);
        }

        public async Task<EquipoDTO> GetById(EquipoDTO entity)
        {
            return await _service.GetById(controllerName, entity);
        }

        public async Task<IEnumerable<EquipoDTO>> GetListEntity(EquipoDTO entity)
        {
            return await _service.GetListEntity(controllerName, entity);
        }

        public async Task<IEnumerable<EquipoDTO>> GetTs(bool isDbQuery, string dbPath, string jsonName)
        {
            if (isDbQuery)
            {
                return await _service.GetTs(controllerName);
            }
            else
            {
                var read = File.ReadAllText($"{dbPath}{jsonName}");
                return JsonConvert.DeserializeObject<IEnumerable<EquipoDTO>>(read);
            }
        }

        public async Task<bool> Post(EquipoDTO entity, bool isNewItem)
        {
            return await _service.Post(controllerName, entity, isNewItem);
        }
    }
}
