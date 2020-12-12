using API.Domain.DTOs;
using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class FormaPagoRepository : IFormaPago<FormaPagoDTO>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;

        public FormaPagoRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Delete(FormaPagoDTO entity)
        {
            var model = await _context.Tbformapago.SingleOrDefaultAsync(x => x.IdFormaPago == entity.IdFormaPago);
            if (model == null)
                return false;
            _context.Tbformapago.Remove(model);
            int query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Exists(FormaPagoDTO entity)
        {
            return await _context.Tbformapago.AnyAsync(e => e.IdFormaPago == entity.IdFormaPago);
        }

        public async Task<IEnumerable<FormaPagoDTO>> Get()
        {
            return _mapper.Map<IEnumerable<FormaPagoDTO>>(await _context.Tbformapago.ToListAsync());
        }

        public async Task<FormaPagoDTO> GetById(FormaPagoDTO entity)
        {
            var model = await _context.Tbformapago.Where(x => x.IdFormaPago == entity.IdFormaPago).FirstOrDefaultAsync();
            return _mapper.Map<FormaPagoDTO>(model);
        }

        public async Task<bool> Post(FormaPagoDTO entity)
        {
            var model = _mapper.Map<Tbformapago>(entity);
            _context.Tbformapago.Add(model);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Put(FormaPagoDTO entity)
        {
            _context.Entry(_mapper.Map<Tbformapago>(entity)).State = EntityState.Modified;
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }
    }
}
