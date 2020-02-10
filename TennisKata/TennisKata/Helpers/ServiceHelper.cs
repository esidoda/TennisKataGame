using Microsoft.Extensions.DependencyInjection;
using System;
using TennisKata.Abstract;
using TennisKata.Concrete;

namespace TennisKata.Helpers
{
    /// <summary>
    /// Class responsible for the service container configuration of Dependency Injection.
    /// </summary>
    public static class ServiceHelper
    {
        /// <summary>
        /// Registers the necessary services.
        /// </summary>
        /// <returns></returns>
        public static ServiceProvider RegisterServices()
        {
            // Configure services
            IServiceCollection services = new ServiceCollection()
                .AddTransient<IConsoleService, ConsoleService>()
                .AddTransient<IPlayerService, PlayerService>()
                .AddTransient<IPointService, PointService>();

            // Create a service provider from the service collection
            return services.BuildServiceProvider();
        }

        /// <summary>
        /// Disposes the registered instances.
        /// </summary>
        /// <param name="serviceProvider"></param>
        public static void DisposeServices(IServiceProvider serviceProvider)
        {
            if (serviceProvider is IDisposable)
            {
                ((IDisposable)serviceProvider).Dispose();
            }
        }
    }
}
