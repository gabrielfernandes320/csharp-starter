using System.Threading.Tasks;

namespace csharp_template_v1._0.Modules.User.Repositories
{
    public interface IUsersRepository
    {
        Task<object> FindById(int id);
    }
}
