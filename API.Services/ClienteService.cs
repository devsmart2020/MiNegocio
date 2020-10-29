using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class ClienteService : IClienteService<Tbcliente>
    {
        private readonly ICliente<Tbcliente> _repository;

        public ClienteService(ICliente<Tbcliente> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(Tbcliente entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(Tbcliente entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<Tbcliente> GetById(Tbcliente entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<Tbcliente>> Get()
        {
            return await _repository.Get();
        }

        public async Task<Tbcliente> Post(Tbcliente entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<Tbcliente> Put(Tbcliente entity)
        {
            return await _repository.Put(entity);
        }
    }
}
