using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Domain.Interfaces
{
    public interface IEstadoOrden<T>
    {
        Task<bool> Delete(T entity);
        Task<bool> Exists(T entity);
        Task<T> GetById(T entity);
        Task<IEnumerable<T>> Get();
        Task<bool> Post(T entity);
        Task<bool> Put(T entity);
    }
}
