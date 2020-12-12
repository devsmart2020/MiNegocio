using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class UsuarioOrdenService : IUsuarioOrdenService<UsuarioOrdenDTO>
    {
        private readonly IUsuarioOrden<UsuarioOrdenDTO> _repository;

        public UsuarioOrdenService(IUsuarioOrden<UsuarioOrdenDTO> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(UsuarioOrdenDTO entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(UsuarioOrdenDTO entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<UsuarioOrdenDTO> GetById(UsuarioOrdenDTO entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<UsuarioOrdenDTO>> Get()
        {
            return await _repository.Get();
        }

        public async Task<bool> Post(UsuarioOrdenDTO entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<bool> Put(UsuarioOrdenDTO entity)
        {
            return await _repository.Put(entity);
        }
    }
}
