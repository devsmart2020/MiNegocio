using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class PerfilService : IPerfilService<PerfilDTO>
    {
        private readonly IPerfil<PerfilDTO> _repository;

        public PerfilService(IPerfil<PerfilDTO> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(PerfilDTO entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(PerfilDTO entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<PerfilDTO> GetById(PerfilDTO entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<PerfilDTO>> Get()
        {
            return await _repository.Get();
        }

        public async Task<bool> Post(PerfilDTO entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<bool> Put(PerfilDTO entity)
        {
            return await _repository.Put(entity);
        }
    }
}
