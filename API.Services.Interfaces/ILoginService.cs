using System.Threading.Tasks;

namespace API.Services.Interfaces
{
    public interface ILoginService<T> where T : class
    {
        Task<T> GetUsuario(T entity);
    }

}
