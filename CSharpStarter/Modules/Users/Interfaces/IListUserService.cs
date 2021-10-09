using CSharpStarter.Modules.Users.Infra.Ef.Entities;
using CSharpStarter.Shared.Interfaces;
using System.Collections.Generic;

namespace CSharpStarter.Modules.Users.Interfaces
{
    public interface IListUserService : IService<object, ICollection<User>>
    {
    }
}
