using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class FormaPagoService : IFormaPagoService<Tbformapago>
    {
        private readonly IFormaPago<Tbformapago> _repository;

        public FormaPagoService(IFormaPago<Tbformapago> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Tbformapago entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(Tbformapago entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<Tbformapago> GetById(Tbformapago entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<Tbformapago>>Get()
        {
            return await _repository.Get();
        }

        public async Task<Tbformapago> Post(Tbformapago entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<Tbformapago> Put(Tbformapago entity)
        {
            return await _repository.Put(entity);
        }
    }
}
