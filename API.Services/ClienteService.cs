using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class ClienteService : IClienteService<ClienteDto>
    {
        private readonly ICliente<ClienteDto> _repository;



        public ClienteService(ICliente<ClienteDto> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(ClienteDto entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(ClienteDto entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<ClienteDto> GetById(ClienteDto entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<ClienteDto>> Get()
        {
            return await _repository.Get();
        }

        public async Task<ClienteDto> Post(ClienteDto entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<ClienteDto> Put(ClienteDto entity)
        {
            return await _repository.Put(entity);
        }

        public async Task<IEnumerable<ClienteDto>> RptEquiposxCliente(ClienteDto entity)
        {
            return await _repository.RptEquiposxCliente(entity);
        }

        public async Task<IEnumerable<ClienteDto>> RptOrdenxCliente(ClienteDto entity)
        {
            return await _repository.RptOrdenxCliente(entity);
        }
    }
}
