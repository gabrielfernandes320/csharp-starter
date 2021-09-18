using csharp_template_v1._0.Modules.User.Repositories;
using System.Threading.Tasks;
using csharp_template_v1._0.src.shared.infra.ef.contexts;

namespace csharp_template_v1._0.Modules.User.Infra.Ef.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly Context context;

        public UsersRepository(Context context)
        {
            this.context = context;
        }

        public async Task<object> FindById(int id)
        {
            var user = await context.Users.FindAsync(id);
            return user;
        }
    }
}
