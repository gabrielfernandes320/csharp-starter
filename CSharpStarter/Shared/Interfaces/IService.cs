using System.Threading.Tasks;

namespace CSharpStarter.Shared.Interfaces
{
    public interface IService<T>
    {
        public Task<T> Execute(T entity);
    }

    public interface IService<T, R>
    {
        public Task<R> Execute(T entity);
    }

    public interface IService<P, T, R>
    {
        public Task<R> Execute(P param, T entity);
    }

    

}
