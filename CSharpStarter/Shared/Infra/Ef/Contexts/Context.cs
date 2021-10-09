using CSharpStarter.Modules.Users.Infra.Ef.Entities;
using Microsoft.EntityFrameworkCore;

namespace CSharpStarter.Shared.Infra.Ef.Contexts
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
        : base(options)
        { }

        public DbSet<User> Users { get; set; }
    }
}
