using CSharpStarter.Modules.Users.Infra.Ef.Entities;
using CSharpStarter.Modules.Users.Interfaces;
using System.Threading.Tasks;

namespace CSharpStarter.Modules.Users.Services
{
    public class CreateUserService : ICreateUserService
    {
        private readonly IUsersRepository _usersRepository = null; 
        public CreateUserService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public Task<User> Execute(User entity)
        {
            return _usersRepository.Create(entity);
        }
    }
}
