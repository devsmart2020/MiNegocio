using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class VentaService : IVentaService<Tbventa>
    {
        private readonly IVenta<Tbventa> _repository;

        public VentaService(IVenta<Tbventa> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Tbventa entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(Tbventa entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<IEnumerable<Tbventa>> Get()
        {
            return await _repository.Get();
        }

        public async Task<Tbventa> GetById(Tbventa entity)
        {
            return await _repository.GetById(entity);
        }

        public async  Task<Tbventa> Post(Tbventa entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<Tbventa> Put(Tbventa entity)
        {
            return await _repository.Put(entity);
        }
    }
}
