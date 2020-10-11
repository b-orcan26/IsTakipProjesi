using Business.Concrete;
using Business.Interfaces;
using Business.ValidationRules;
using DAL.Repositories.DapperRepositories.Concrete;
using DAL.Repositories.DapperRepositories.Interfaces;
using DTO;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace Business.CustomCollectionExtensions
{
    public static class AddContainerWithDependencies
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IGorevRepository, GorevRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IRaporRepository, RaporRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IMessageRepository, MessageRepository>();
        }

        public static void AddManagers(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IRoleService, RoleManager>();
            services.AddScoped<IGorevService, GorevManager>();
            services.AddScoped<IRaporService, RaporManager>();
            services.AddScoped<IAuthService, AuthManager>();
            services.AddScoped<IMessageService, MessageManager>();
        } 

        public static void AddValidators(this IServiceCollection services)
        {
            services.AddTransient<IValidator<GorevEkleDTO>, GorevEkleValidator>();
            services.AddTransient<IValidator<GorevGuncelleDTO>, GorevGuncelleValidator>();
            services.AddTransient<IValidator<LoginDTO>, LoginValidator>();
            services.AddTransient<IValidator<ParolaUpdateDTO>, ParolaUpdateValidator>();
            services.AddTransient<IValidator<RaporAddDTO>, RaporAddValidator>();
            services.AddTransient<IValidator<RaporUpdateDTO>, RaporUpdateValidator>();
            services.AddTransient<IValidator<RolEkleDTO>, RolEkleValidator>();
            services.AddTransient<IValidator<RolGuncelleDTO>, RolGuncelleValidator>();
            services.AddTransient<IValidator<UserAddDTO>, UserAddValidator>();
            services.AddTransient<IValidator<UserUpdateDTO>, UserUpdateValidator>();
        }

    }
}
