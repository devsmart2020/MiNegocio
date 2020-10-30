using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class UsuarioService : IUsuarioService<Tbusuario>
    {
        private readonly IUsuario<Tbusuario> _repository;

        public UsuarioService(IUsuario<Tbusuario> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Tbusuario entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(Tbusuario entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<Tbusuario> GetById(Tbusuario entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<Tbusuario>>Get()
        {
            return await _repository.Get();
        }

        public async Task<Tbusuario> Post(Tbusuario entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<Tbusuario> Put(Tbusuario entity)
        {
            return await _repository.Put(entity);
        }

        public async Task<Tbusuario> Login(Tbusuario entity)
        {
            return await _repository.Login(entity);
        }
    }
}
