using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class ReportesService : IReportesService<Tbreportes>
    {
        private readonly IReportes<Tbreportes> _repository;

        public ReportesService(IReportes<Tbreportes> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Tbreportes entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(Tbreportes entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<Tbreportes> GetById(Tbreportes entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<Tbreportes>>Get()
        {
            return await _repository.Get();
        }

        public async Task<Tbreportes> Post(Tbreportes entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<Tbreportes> Put(Tbreportes entity)
        {
            return await _repository.Put(entity);
        }
    }
}
