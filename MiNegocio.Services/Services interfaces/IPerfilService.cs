﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiNegocio.Services.Services_interfaces
{
    public interface IPerfilService<T> where T :class
    {
        Task<bool> Delete(T entity);
        Task<T> GetById(T entity);
        Task<IEnumerable<T>> GetListEntity(T entity);
        Task<IEnumerable<T>> GetTs();
        Task<bool> Post(T entity, bool isNewItem);
    }
}
