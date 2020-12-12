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
    public class ModeloRepository : IModelo<ModeloDTO>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;
        public ModeloRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Delete(ModeloDTO entity)
        {
            var model = await _context.Tbmodelo.SingleOrDefaultAsync(x => x.IdModelo == entity.IdModelo);
            if (model == null)
                return false;
            _context.Tbmodelo.Remove(model);
            int query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Exists(ModeloDTO entity)
        {
            return await _context.Tbmodelo.AnyAsync(e => e.IdModelo == entity.IdModelo);
        }

        public async Task<IEnumerable<ModeloDTO>> Get()
        {
            return _mapper.Map<IEnumerable<ModeloDTO>>(await _context.Tbmodelo.ToListAsync());
        }

        public async Task<ModeloDTO> GetById(ModeloDTO entity)
        {
            var model = await _context.Tbmodelo.Where(x => x.IdModelo == entity.IdModelo).FirstOrDefaultAsync();
            return _mapper.Map<ModeloDTO>(model);
        }

        public async Task<bool> Post(ModeloDTO entity)
        {
            var model = _mapper.Map<Tbmodelo>(entity);
            _context.Tbmodelo.Add(model);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Put(ModeloDTO entity)
        {
            _context.Entry(_mapper.Map<Tbmodelo>(entity)).State = EntityState.Modified;
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }
    }
}
