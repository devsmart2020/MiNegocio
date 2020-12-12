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
    public class ConceptoRepository : IConcepto<ConceptoDTO>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;

        public ConceptoRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> Delete(ConceptoDTO entity)
        {
            var model = await _context.Tbconcepto.SingleOrDefaultAsync(x => x.IdConcepto == entity.IdConcepto);
            if (model == null)
                return false;
            _context.Tbconcepto.Remove(model);
            int query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Exists(ConceptoDTO entity)
        {
            return await _context.Tbconcepto.AnyAsync(e => e.IdConcepto == entity.IdConcepto);
        }

        public async Task<IEnumerable<ConceptoDTO>> Get()
        {
            return _mapper.Map<IEnumerable<ConceptoDTO>>(await _context.Tbconcepto.ToListAsync());
        }

        public async Task<ConceptoDTO> GetById(ConceptoDTO entity)
        {
            var model = await _context.Tbconcepto.Where(x => x.IdConcepto == entity.IdConcepto).FirstOrDefaultAsync();
            return _mapper.Map<ConceptoDTO>(model);
        }

        public async Task<bool> Post(ConceptoDTO entity)
        {
            var model = _mapper.Map<Tbconcepto>(entity);
            _context.Tbconcepto.Add(model);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Put(ConceptoDTO entity)
        {
            _context.Entry(_mapper.Map<Tbconcepto>(entity)).State = EntityState.Modified;
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }
    }
}
