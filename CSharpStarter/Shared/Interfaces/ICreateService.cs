using System.Threading.Tasks;

namespace CSharpStarter.Shared.Interfaces
{
    public interface ICreateService<T>
    {
        public Task<T> Execute(T entity);
    }
}
