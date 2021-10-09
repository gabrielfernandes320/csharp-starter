using CSharpStarter.Modules.Users.Infra.Ef.Entities;
using CSharpStarter.Modules.Users.Interfaces;
using CSharpStarter.Shared.Interfaces;
using System.Threading.Tasks;

namespace CSharpStarter.Modules.Users.Services
{
    public class UpdateUserService : IUpdateUserService
    {
        private readonly IUsersRepository _usersRepository = null; 
        public UpdateUserService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public Task<User> Execute(int param, User entity)
        {
            return _usersRepository.Update(param, entity);
        }
    }
}
