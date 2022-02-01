using $safeprojectname$.Infrastructure.Data.DbContexts.Entities;
using Microsoft.EntityFrameworkCore;

namespace $safeprojectname$.Infrastructure.Data.DbContexts
{
    public class $safeprojectname$DbContext : DbContext, IUnitOfWork
    {
        public DbSet<ContactPerson> ContactPersons { get; set; }

        public $safeprojectname$DbContext(DbContextOptions<$safeprojectname$DbContext> options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof($safeprojectname$DbContext).Assembly);
        }
    }
}