using CSharpStarter.Modules.Users.Infra.Ef.Entities;
using CSharpStarter.Shared.Infra.Ef.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpStarter.Shared.Infra.Ef.Contexts
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
        : base(options)
        {

        }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasQueryFilter(p => p.DeletedAt == null);
        }

        public override int SaveChanges()
        {
            UseUpdatedAndCreatedAt();
            UseSoftDelete();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            UseUpdatedAndCreatedAt();
            UseSoftDelete();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void UseUpdatedAndCreatedAt()
        {
            var entities = ChangeTracker.Entries()
                .Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).CreatedAt = DateTime.UtcNow;
                }
                ((BaseEntity)entity.Entity).UpdatedAt = DateTime.UtcNow;
            }
        }

        private void UseSoftDelete()
        {
            var entities = ChangeTracker.Entries()
               .Where(e => e.State == EntityState.Deleted &&
               e.Metadata.GetProperties().Any(x => x.Name == "DeletedAt"));

            foreach (var item in entities)
            {
                item.State = EntityState.Unchanged;
                item.CurrentValues["DeletedAt"] = DateTime.UtcNow;
            }
        }

    }
}
