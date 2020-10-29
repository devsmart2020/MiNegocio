using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class UsuarioOrden : IUsuarioOrdenService<Tbusuarioorden>
    {
        private readonly IUsuarioOrden<Tbusuarioorden> _repository;

        public UsuarioOrden(IUsuarioOrden<Tbusuarioorden> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Tbusuarioorden entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(Tbusuarioorden entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<Tbusuarioorden> GetById(Tbusuarioorden entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<Tbusuarioorden>>Get()
        {
            return await _repository.Get();
        }

        public async Task<Tbusuarioorden> Post(Tbusuarioorden entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<Tbusuarioorden> Put(Tbusuarioorden entity)
        {
            return await _repository.Put(entity);
        }
    }
}
