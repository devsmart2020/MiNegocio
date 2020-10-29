using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class CreditoService : ICreditoService<Tbcredito>
    {
        private readonly ICredito<Tbcredito> _repository;

        public CreditoService(ICredito<Tbcredito> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Tbcredito entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(Tbcredito entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<Tbcredito> GetById(Tbcredito entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<Tbcredito>>Get()
        {
            return await _repository.Get();
        }

        public async Task<Tbcredito> Post(Tbcredito entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<Tbcredito> Put(Tbcredito entity)
        {
            return await _repository.Put(entity);
        }
    }
}
