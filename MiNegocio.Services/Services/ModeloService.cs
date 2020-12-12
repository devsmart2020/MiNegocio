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
    public class ModeloService : IModeloService<ModeloDTO>
    {
        private readonly string controllerName = Resources.ModelController;
        private protected readonly IRestService<ModeloDTO> _service;
        public ModeloService()
        {
            _service = new RestService<ModeloDTO>();
        }

        public async Task<bool> Delete(ModeloDTO entity)
        {
            return await _service.Delete(entity.IdModelo);
        }

        public async Task<ModeloDTO> GetById(ModeloDTO entity)
        {
            return await _service.GetById(controllerName, entity);
        }

        public async Task<IEnumerable<ModeloDTO>> GetListEntity(ModeloDTO entity)
        {
            return await _service.GetListEntity(controllerName, entity);
        }

        public async Task<IEnumerable<ModeloDTO>> GetTs(bool isDbQuery, string dbPath, string jsonName)
        {
            if (isDbQuery)
            {
                return await _service.GetTs(controllerName);
            }
            else
            {
                var read = File.ReadAllText($"{dbPath}{jsonName}");
                return JsonConvert.DeserializeObject<IEnumerable<ModeloDTO>>(read);
            }
        }

        public async Task<bool> Post(ModeloDTO entity, bool isNewItem)
        {
            return await _service.Post(controllerName, entity, isNewItem);
        }
    }
}
