using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class PerfilService : IPerfilService<Tbperfil>
    {
        private readonly IPerfil<Tbperfil> _repository;

        public PerfilService(IPerfil<Tbperfil> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(Tbperfil entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(Tbperfil entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<Tbperfil> GetById(Tbperfil entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<Tbperfil>> Get()
        {
            return await _repository.Get();
        }

        public async Task<Tbperfil> Post(Tbperfil entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<Tbperfil> Put(Tbperfil entity)
        {
            return await _repository.Put(entity);
        }
    }
}
