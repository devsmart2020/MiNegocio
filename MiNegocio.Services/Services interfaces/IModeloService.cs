using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiNegocio.Services.Services_interfaces
{
    public interface IModeloService<T>
    {
        Task<bool> Delete(T entity);
        Task<T> GetById(T entity);
        Task<IEnumerable<T>> GetListEntity(T entity);
        Task<IEnumerable<T>> GetTs(bool isDbQuery, string dbPath, string jsonName);
        Task<bool> Post(T entity, bool isNewItem);
    }
}
