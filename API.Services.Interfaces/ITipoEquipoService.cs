﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services.Interfaces
{
    public interface ITipoEquipoService<T>
    {
        Task<bool> Delete(T entity);
        Task<bool> Exists(T entity);
        Task<T> GetById(T entity);
        Task<IEnumerable<T>> Get();
        Task<T> Post(T entity);
        Task<T> Put(T entity);
    }
}