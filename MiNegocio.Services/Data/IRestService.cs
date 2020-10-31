using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiNegocio.Services.Data
{
    public interface IRestService<T>
    {
        Task<bool> Delete(string id);
        Task<T> GetById(string controllerName, T entity);
        Task<IEnumerable<T>> GetListEntity(string controllerName, T entity);
        Task<IEnumerable<T>> GetTs(string controllerName);
        Task<T> Login(string controllerName, T entity);
        Task<bool> Post(string controllerName, T entity, bool isNewItem);

    
    }
}
