using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class ModeloService : IModeloService<ModeloDTO>
    {
        private readonly IModelo<ModeloDTO> _repository;

        public ModeloService(IModelo<ModeloDTO> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(ModeloDTO entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(ModeloDTO entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<ModeloDTO> GetById(ModeloDTO entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<ModeloDTO>> Get()
        {
            return await _repository.Get();
        }

        public async Task<bool> Post(ModeloDTO entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<bool> Put(ModeloDTO entity)
        {
            return await _repository.Put(entity);
        }
    }
}
