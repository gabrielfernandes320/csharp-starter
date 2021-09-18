using csharp_template.src.modules.auth.infra.ef.entities;
using csharp_template.src.modules.user.infra.ef.entities;
using Microsoft.EntityFrameworkCore;
using EFCore.NamingConventions;

namespace csharp_template_v1._0.src.shared.infra.ef.contexts
{
    public class Context : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql("User ID=postgres;Password=admin;Host=localhost;Port=5432;Database=innova2;Pooling=true;")
                .UseSnakeCaseNamingConvention();
        }

    }
}
