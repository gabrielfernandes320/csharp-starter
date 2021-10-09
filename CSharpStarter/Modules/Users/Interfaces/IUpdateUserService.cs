using CSharpStarter.Modules.Users.Infra.Ef.Entities;
using CSharpStarter.Shared.Interfaces;

namespace CSharpStarter.Modules.Users.Interfaces
{
    public interface IUpdateUserService : IService<int, User, User>
    {
    }
}
