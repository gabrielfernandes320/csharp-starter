using CSharpStarter.Modules.Users.Infra.Ef.Entities;
using CSharpStarter.Shared.Interfaces;
using System.Collections.Generic;

namespace CSharpStarter.Modules.Users.Interfaces
{
    public interface IShowUserService : IService<int, User>
    {
    }
}
