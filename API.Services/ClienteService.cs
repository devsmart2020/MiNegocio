using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System;
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

        public Task<bool> Delete(Tbcliente entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exists(Tbcliente entity)
        {
            throw new NotImplementedException();
        }

        public Task<Tbcliente> GetById(Tbcliente entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Tbcliente>> Get()
        {
            return await _repository.Get();
        }

        public Task<Tbcliente> Post(Tbcliente entity)
        {
            throw new NotImplementedException();
        }

        public Task<Tbcliente> Put(Tbcliente entity)
        {
            throw new NotImplementedException();
        }
    }
}
