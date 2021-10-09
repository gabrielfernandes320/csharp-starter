using CSharpStarter.Modules.Users.Infra.Ef.Entities;
using CSharpStarter.Modules.Users.Interfaces;
using CSharpStarter.Shared.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpStarter.Modules.Users.Services
{
    public class ListUserService : IListUserService
    {
        private readonly IUsersRepository _usersRepository = null; 
        public ListUserService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public async Task<ICollection<User>> Execute(object entity)
        {
            return await _usersRepository.FindAll();
        }
    }
}
