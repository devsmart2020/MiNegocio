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
    public class MarcaService : IMarcaService<MarcaDTO>
    {
        private readonly string controllerName = Resources.MarcaController;
        private protected readonly IRestService<MarcaDTO> _service;

        public MarcaService()
        {
            _service = new RestService<MarcaDTO>();
        }

        public async Task<bool> Delete(MarcaDTO entity)
        {
            return await _service.Delete(entity.IdMarca);
        }

        public async Task<MarcaDTO> GetById(MarcaDTO entity)
        {
            return await _service.GetById(controllerName, entity);
        }

        public async Task<IEnumerable<MarcaDTO>> GetListEntity(MarcaDTO entity)
        {
            return await _service.GetListEntity(controllerName, entity);
        }

        public async Task<IEnumerable<MarcaDTO>> GetTs(bool isDbQuery, string dbPath, string jsonName)
        {
            if (isDbQuery)
            {
                return await _service.GetTs(controllerName);
            }
            else
            {
                var read = File.ReadAllText($"{dbPath}{jsonName}");
                return JsonConvert.DeserializeObject<IEnumerable<MarcaDTO>>(read);
            }
        }

        public async Task<bool> Post(MarcaDTO entity, bool isNewItem)
        {
            return await _service.Post(controllerName, entity, isNewItem);
        }
    }
}
