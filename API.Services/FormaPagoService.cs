using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class FormaPagoService : IFormaPagoService<FormaPagoDTO>
    {
        private readonly IFormaPago<FormaPagoDTO> _repository;

        public FormaPagoService(IFormaPago<FormaPagoDTO> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(FormaPagoDTO entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(FormaPagoDTO entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<FormaPagoDTO> GetById(FormaPagoDTO entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<FormaPagoDTO>> Get()
        {
            return await _repository.Get();
        }

        public async Task<bool> Post(FormaPagoDTO entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<bool> Put(FormaPagoDTO entity)
        {
            return await _repository.Put(entity);
        }
    }
}
