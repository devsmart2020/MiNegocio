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
    public class UsuarioService : IUsuarioService<UsuarioDTO>
    {
        private readonly IRestService<UsuarioDTO> _service;
        private readonly string controllerName = Resources.UsersController;

        public UsuarioService()
        {
            _service = new RestService<UsuarioDTO>();
        }

        public async Task<bool> Delete(UsuarioDTO entity)
        {
            return await _service.Delete(entity.DocId);
        }

        public async Task<UsuarioDTO> GetById(UsuarioDTO entity)
        {
            return await _service.GetById(controllerName, entity);
        }

        public async Task<IEnumerable<UsuarioDTO>> GetListEntity(UsuarioDTO entity)
        {
            return await _service.GetListEntity(controllerName, entity);
        }        

        public async Task<IEnumerable<UsuarioDTO>> GetTecnicos(bool isDbQuery, string dbPath, string jsonName)
        {
            if (isDbQuery)
            {
                return await _service.GetTs($"{controllerName}/Tecnicos");
            }
            else
            {
                var read = File.ReadAllText($"{dbPath}{jsonName}");
                return JsonConvert.DeserializeObject<IEnumerable<UsuarioDTO>>(read);
            }           
        }

        public async Task<IEnumerable<UsuarioDTO>> GetTs()
        {
            return await _service.GetTs(controllerName);
        }

        public async Task<bool> Post(UsuarioDTO entity, bool isNewItem)
        {
            return await _service.Post(controllerName, entity, isNewItem);
        }
    }
}
