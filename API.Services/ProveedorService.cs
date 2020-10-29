using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class ProveedorService : IProveedorService<Tbproveedor>
    {
        private readonly IProveedor<Tbproveedor> _repository;

        public ProveedorService(IProveedor<Tbproveedor> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Tbproveedor entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(Tbproveedor entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<Tbproveedor> GetById(Tbproveedor entity)
        {
            return await _repository.GetById(entity);
        }

       public async Task<IEnumerable<Tbproveedor>>Get()
        {
            return await _repository.Get();
        }

        public async Task<Tbproveedor> Post(Tbproveedor entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<Tbproveedor> Put(Tbproveedor entity)
        {
            return await _repository.Put(entity);
        }
    }
}
