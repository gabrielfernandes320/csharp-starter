using CSharpStarter.Modules.Users.Infra.Ef.Entities;
using CSharpStarter.Shared.Infra.Ef.Repositories;
using System.Threading.Tasks;

namespace CSharpStarter.Modules.Users.Interfaces
{
    public interface IUsersRepository : IBaseRepository<User>
    {
        public User FindByEmail(string email);
    }
}
