using CSharpStarter.Modules.Users.Infra.Ef.Entities;
using CSharpStarter.Modules.Users.Interfaces;
using CSharpStarter.Shared.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpStarter.Modules.Users.Services
{
    public class ShowUserService : IShowUserService
    {
        private readonly IUsersRepository _usersRepository = null; 
        public ShowUserService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public async Task<User> Execute(int id)
        {
            return await _usersRepository.FindById(id);
        }
    }
}
