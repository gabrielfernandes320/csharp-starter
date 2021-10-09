using CSharpStarter.Modules.Users.Infra.Ef.Entities;
using CSharpStarter.Shared.Interfaces;
using System;
using System.Threading.Tasks;

namespace CSharpStarter.Modules.Users.Interfaces
{
    public interface IDeleteUserService : IService<int, Task>
    {
    }
}
