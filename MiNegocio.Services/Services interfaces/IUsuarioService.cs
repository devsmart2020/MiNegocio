using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiNegocio.Services.Services_interfaces
{
    public interface IUsuarioService<T> where T : class
    {
        Task<bool> Delete(T entity);
        Task<T> GetById(T entity);
        Task<IEnumerable<T>> GetListEntity(T entity);
        Task<IEnumerable<T>> GetTs();
        Task<IEnumerable<T>> GetTecnicos(bool isDbQuery, string dbPath, string jsonName);
        Task<bool> Post(T entity, bool isNewItem);
    }
}
