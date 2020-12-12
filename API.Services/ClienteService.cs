using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class ClienteService : IClienteService<ClienteDTO>
    {
        private readonly ICliente<ClienteDTO> _repository;
        public ClienteService(ICliente<ClienteDTO> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(ClienteDTO entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(ClienteDTO entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<IEnumerable<ClienteDTO>> Get()
        {
            return await _repository.Get();
        }

        public async Task<ClienteDTO> GetById(ClienteDTO entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<bool> Post(ClienteDTO entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<bool> Put(ClienteDTO entity)
        {
            return await _repository.Put(entity);
        }

        public async Task<IEnumerable<ClienteDTO>> RptEquiposxCliente(ClienteDTO entity)
        {
            return await _repository.RptEquiposxCliente(entity);
        }

        public async Task<IEnumerable<ClienteDTO>> RptOrdenxCliente(ClienteDTO entity)
        {
            return await _repository.RptOrdenxCliente(entity);
        }        
    }
}
