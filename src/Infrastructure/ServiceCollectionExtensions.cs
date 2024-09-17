using Application.Repositories;
using Application.Services;
using Domain;
using Infrastructure.Repositories;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IReservationRepository, ReservationRepository>();
            var appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var dbPath = Path.Combine(appDataFolder, "StepStyle");
            if (!Directory.Exists(dbPath))
            {
                Directory.CreateDirectory(dbPath);
            }
            services.AddDbContext<ShoeDbContext>(options => options.UseSqlite($"Data Source={Path.Combine(dbPath, "shoes.db")}"));
            services.AddScoped<IMigrationService, MigrationService>();
            return services;
        }
    }
}
