using CSharpStarter.Modules.Users.Infra.Ef.Entities;
using CSharpStarter.Shared.Interfaces;

namespace CSharpStarter.Modules.Users.Interfaces
{
    public interface ICreateUserService : ICreateService<User>
    {
    }
}
