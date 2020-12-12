using MiNegocio.Models.Models;
using MiNegocio.Services.Data;
using MiNegocio.Services.Properties;
using MiNegocio.Services.Services_interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace MiNegocio.Services.Services
{
    public class OrdenService : IOrdenService<OrdenDTO>
    {
        private protected readonly string controllerName = Resources.OrdenController;
        private readonly IRestService<OrdenDTO> _service;
        public OrdenService()
        {
            _service = new RestService<OrdenDTO>();
        }
        public async Task<bool> Delete(OrdenDTO entity)
        {
            return await _service.Delete(entity);
        }

        public async Task<OrdenDTO> GetById(OrdenDTO entity)
        {
            return await _service.GetById(controllerName, entity);
        }

        public async Task<IEnumerable<OrdenDTO>> GetListEntity(OrdenDTO entity)
        {
            return await _service.GetListEntity(controllerName, entity);
        }

        public async Task<IEnumerable<OrdenDTO>> GetTs(bool isDbQuery, string dbPath, string jsonName)
        {
            if (isDbQuery)
            {
                return await _service.GetTs(controllerName);
            }
            else
            {
                var read = File.ReadAllText($"{dbPath}{jsonName}");
                return JsonConvert.DeserializeObject<IEnumerable<OrdenDTO>>(read);
            }
        }

        public async Task<bool> Post(OrdenDTO entity, bool isNewItem)
        {
            return await _service.Post(controllerName, entity, isNewItem);
        }
    }
}
