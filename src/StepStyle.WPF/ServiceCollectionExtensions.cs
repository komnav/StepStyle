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
using System.Windows;

namespace StepStyle.WPF
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddWpfServices(this IServiceCollection services)
        {
            services.AddSingleton<App>();
            services.AddSingleton<LoginView>();
            services.AddViews();
            services.AddViewModels();
            services.AddApplicationServices();
            services.AddInfrastructureServices();

            services.AddSingleton<ILeftMenuView, ReservationView>();
            services.AddSingleton<ILeftMenuView, ClientInfoPage>();
            services.AddScoped<ILeftMenuView, BookedView>();
            return services;
        }

        public static IServiceCollection AddViews(this IServiceCollection services)
        {
            var allViews = typeof(ServiceCollectionExtensions).Assembly.GetExportedTypes()
                .Where(s => s.BaseType == typeof(Window) && s != typeof(LoginView));
            foreach (var view in allViews)
            {
                services.AddTransient(view);
            }
            return services;
        }

        public static IServiceCollection AddViewModels(this IServiceCollection services)
        {
            var allViewModels = typeof(ServiceCollectionExtensions).Assembly.GetExportedTypes()
                 .Where(s => s.BaseType == typeof(BaseViewModel));
            foreach (var viewModel in allViewModels)
            {
                services.AddTransient(viewModel);
            }
            return services;
        }
    }
}
