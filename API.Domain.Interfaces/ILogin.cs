using System.Threading.Tasks;

namespace API.Domain.Interfaces
{
    public interface ILogin<T> where T : class
    {
        Task<T> GetUsuario(T entity);
    }
}
