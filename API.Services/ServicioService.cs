using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class ServicioService : IServicioService<Tbservicio>
    {
        private readonly IServicio<Tbservicio> _repository;

        public ServicioService(IServicio<Tbservicio> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Tbservicio entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(Tbservicio entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<Tbservicio> GetById(Tbservicio entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<Tbservicio>>Get()
        {
            return await _repository.Get();
        }

        public async Task<Tbservicio> Post(Tbservicio entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<Tbservicio> Put(Tbservicio entity)
        {
            return await _repository.Put(entity);
        }
    }
}
