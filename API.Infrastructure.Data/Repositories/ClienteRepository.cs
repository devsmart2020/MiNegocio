using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class ClienteRepository : ICliente<Tbcliente>
    {
        private readonly soport43_minegociopruebasContext _context;

        public ClienteRepository(soport43_minegociopruebasContext context)
        {
            _context = context;
        }

        public Task<bool> Delete(Tbcliente entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exists(Tbcliente entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Tbcliente>> Get()
        {
            return await _context.Tbcliente
                .OrderBy(x => x.Nombres)
                .ToListAsync();
        }

        public Task<Tbcliente> GetById(Tbcliente entity)
        {
            throw new NotImplementedException();
        }

        public Task<Tbcliente> Post(Tbcliente entity)
        {
            throw new NotImplementedException();
        }

        public Task<Tbcliente> Put(Tbcliente entity)
        {
            throw new NotImplementedException();
        }
    }
}
