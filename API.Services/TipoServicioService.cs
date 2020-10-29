using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class TipoServicioService : ITipoServicioService<Tbtiposervicio>
    {
        private readonly ITipoServicio<Tbtiposervicio> _repository;

        public TipoServicioService(ITipoServicio<Tbtiposervicio> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(Tbtiposervicio entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(Tbtiposervicio entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<Tbtiposervicio> GetById(Tbtiposervicio entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<Tbtiposervicio>> Get()
        {
            return await _repository.Get();
        }

        public async Task<Tbtiposervicio> Post(Tbtiposervicio entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<Tbtiposervicio> Put(Tbtiposervicio entity)
        {
            return await _repository.Put(entity);
        }
    }
}
