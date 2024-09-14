using Application;
using Application.Services;
using Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using StepStyle.WPF.ViewModels;
using StepStyle.WPF.Views;
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
            services.AddSingleton<LoginView>();
            services.AddTransient<LoginViewModel>();
            services.AddApplicationServices();
            services.AddInfrastructureServices();
            return services;
        }
    }
}
