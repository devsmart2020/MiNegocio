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
    public class TipoEquipoService : ITipoEquipoService<TipoEquipoDTO>
    {
        private readonly string controllerName = Resources.TipoEquipoController;
        private protected readonly IRestService<TipoEquipoDTO> _service;

        public TipoEquipoService()
        {
            _service = new RestService<TipoEquipoDTO>();    
        }

        public async Task<bool> Delete(TipoEquipoDTO entity)
        {
            return await _service.Delete(entity.IdTipoEquipo);
        }

        public async Task<TipoEquipoDTO> GetById(TipoEquipoDTO entity)
        {
            return await _service.GetById(controllerName, entity);
        }

        public async Task<IEnumerable<TipoEquipoDTO>> GetListEntity(TipoEquipoDTO entity)
        {
            return await _service.GetListEntity(controllerName, entity);
        }

        public async Task<IEnumerable<TipoEquipoDTO>> GetTs(bool isDbQuery, string dbPath, string jsonName)
        {
            if (isDbQuery)
            {
                return await _service.GetTs(controllerName);
            }
            else
            {
                var read = File.ReadAllText($"{dbPath}{jsonName}");
                return JsonConvert.DeserializeObject<IEnumerable<TipoEquipoDTO>>(read);
            }
        }

        public async Task<bool> Post(TipoEquipoDTO entity, bool isNewItem)
        {
            return await _service.Post(controllerName, entity, isNewItem);
        }
    }
}
