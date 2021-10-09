using CSharpStarter.Modules.Users.Interfaces;
using System.Threading.Tasks;

namespace CSharpStarter.Modules.Users.Services
{
    public class DeleteUserService : IDeleteUserService
    {
        private readonly IUsersRepository _usersRepository = null;
        public DeleteUserService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public async Task<Task> Execute(int id)
        {
            await _usersRepository.Delete(id);

            return Task.CompletedTask;
        }
    }
}
