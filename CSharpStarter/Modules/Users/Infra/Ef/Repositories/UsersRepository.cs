using CSharpStarter.Modules.Users.Infra.Ef.Entities;
using CSharpStarter.Modules.Users.Interfaces;
using CSharpStarter.Shared.Infra.Ef.Contexts;
using CSharpStarter.Shared.Infra.Ef.Repositories;
using System.Linq;

namespace CSharpStarter.Modules.Users.Infra.Ef.Repositories
{
    public class UsersRepository : BaseRepository<User>, IUsersRepository
    {
        private readonly Context _context = null;
        public UsersRepository(Context context) : base(context)
        {
            _context = context;
        }

        public User FindByEmail(string email)
        {
            return _context.Users.SingleOrDefault(x => x.Email == email);
        }
    }
}
