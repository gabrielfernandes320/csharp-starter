using CSharpStarter.Modules.Users.Infra.Ef.Repositories;
using CSharpStarter.Modules.Users.Interfaces;
using CSharpStarter.Modules.Users.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CSharpStarter.Modules.Users
{
    public static class UsersModule
    {
        public static void AddUsersModule(this IServiceCollection services)
        {
            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped<ICreateUserService, CreateUserService>();
            services.AddScoped<IUpdateUserService, UpdateUserService>();
            services.AddScoped<IDeleteUserService, DeleteUserService>();
            services.AddScoped<IListUserService, ListUserService>();
            services.AddScoped<IShowUserService, ShowUserService>();
        }

    }
}
