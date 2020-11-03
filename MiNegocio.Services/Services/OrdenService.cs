using MiNegocio.Models.Models;
using MiNegocio.Services.Data;
using MiNegocio.Services.Properties;
using MiNegocio.Services.Services_interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiNegocio.Services.Services
{
    public class OrdenService : IOrdenService<Tborden>
    {
        private protected readonly string controllerName = Resources.OrdenController;
        private readonly IRestService<Tborden> _service;
        public OrdenService()
        {
            _service = new RestService<Tborden>();
        }
        public async Task<bool> Delete(Tborden entity)
        {
            return await _service.Delete(entity);
        }

        public async Task<Tborden> GetById(Tborden entity)
        {
            return await _service.GetById(controllerName, entity);
        }

        public async Task<IEnumerable<Tborden>> GetListEntity(Tborden entity)
        {
            return await _service.GetListEntity(controllerName, entity);
        }

        public async Task<IEnumerable<Tborden>> GetTs()
        {
            return await _service.GetTs(controllerName);
        }

        public async Task<bool> Post(Tborden entity, bool isNewItem)
        {
            return await _service.Post(controllerName, entity, isNewItem);
        }
    }
}
