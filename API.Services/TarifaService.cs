using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class TarifaService : ITarifaService<Tbtarifa>
    {
        private readonly ITarifa<Tbtarifa> _repository;

        public TarifaService(ITarifa<Tbtarifa> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Tbtarifa entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(Tbtarifa entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<Tbtarifa> GetById(Tbtarifa entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<Tbtarifa>> Get()
        {
            return await _repository.Get();
        }

        public async Task<Tbtarifa> Post(Tbtarifa entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<Tbtarifa> Put(Tbtarifa entity)
        {
            return await _repository.Put(entity);
        }
    }
}
