using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class UsuarioService : IUsuarioService<UsuarioDTO>
    {
        private readonly IUsuario<UsuarioDTO> _repository;

        public UsuarioService(IUsuario<UsuarioDTO> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(UsuarioDTO entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(UsuarioDTO entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<UsuarioDTO> GetById(UsuarioDTO entity)
        {
            return await _repository.GetById(entity);
        }
        public async Task<IEnumerable<UsuarioDTO>> GetTecnicos()
        {
            return await _repository.GetTecnicos();
        }

        public async Task<IEnumerable<UsuarioDTO>> Get()
        {
            return await _repository.Get();
        }

        public async Task<bool> Post(UsuarioDTO entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<bool> Put(UsuarioDTO entity)
        {
            return await _repository.Put(entity);
        }

        public async Task<UsuarioDTO> Login(UsuarioDTO entity)
        {
            return await _repository.GetById(entity);
        }


    }
}
