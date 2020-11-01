using System.Threading.Tasks;

namespace MiNegocio.Services.Services_interfaces
{
    public interface ILoginService<T> where T : class
    {
        Task<T> Login(T entity);
    }
}
