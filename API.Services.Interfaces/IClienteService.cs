using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services.Interfaces
{
    public interface IClienteService<T> where T : class
    {
        Task<bool> Delete(T entity);
        Task<bool> Exists(T entity);
        Task<T> GetById(T entity);
        Task<IEnumerable<T>> Get();
        Task<bool> Post(T entity);
        Task<bool> Put(T entity);
        Task<IEnumerable<T>> RptEquiposxCliente(T entity);
        Task<IEnumerable<T>> RptOrdenxCliente(T entity);


    }
}
