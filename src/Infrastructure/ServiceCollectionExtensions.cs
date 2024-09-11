﻿using Application.Repositories;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddDbContext<ShoeDbContext>(options => options.UseSqlite("Data Source=C:\\Repos\\StepStyle\\DbContext.db"));

            return services;
        }
    }
}
