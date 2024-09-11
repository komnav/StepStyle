using Application;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepStyle.WPF
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddWpfServices(this IServiceCollection services)
        {
            services.AddSingleton<App>();
            services.AddSingleton<MainWindow>();
            services.AddApplicationServices();

            return services;
        }
    }
}
