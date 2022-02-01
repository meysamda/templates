using $safeprojectname$.Infrastructure.Data.DbContexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace $safeprojectname$.Presentation.Init
{
    public static class DbContexts
    {
        public static void AddDbContexts(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("Default");
            var migrationsAssembly = typeof($safeprojectname$DbContext).Assembly.FullName;

            services.AddDbContext<$safeprojectname$DbContext>(options =>
                options.UseSqlServer(connectionString, sql => sql.MigrationsAssembly(migrationsAssembly))
            );
        }

        public static void Migrate$safeprojectname$DbContext(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<$safeprojectname$DbContext>();
            dbContext.Database.Migrate();
        }
    }
}