using HelpApp.Domain.Interfaces;
using HelpApp.Infra.Data.Context;
using HelpApp.Infra.Data.Repositories;
using HelpApp.Application.Services;
using HelpApp.Application.Mappings;
using MediatR;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using HelpApp.Application.Interfaces;
using HelpApp.Infra.Data.Identity;
using Microsoft.AspNetCore.Identity;
using HelpApp.Domain.Account;

namespace HelpApp.Infra.IoC
{
    public static class DependencyInjectionAPI
    {
        public static IServiceCollection AddInfrastructureAPI(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
             options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"
            ), b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddIdentity<ApplicationUser, IdentityUser>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddScoped<IProductService, ProductServices >();
            services.AddScoped<ICategoryService, CategoryServices>();

            services.AddAutorMap(typeof(DomainToDTOMappingProfile));

            services.AddScoped<IAuthenticate, AuthenticationService>();

            var myHandlers = AppDomain.CurrentDomain.Load("HelpApp Application");

            return services;
        }
    }
}