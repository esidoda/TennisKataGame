using Microsoft.Extensions.DependencyInjection;
using System;
using TennisKata.Abstract;
using TennisKata.Helpers;

namespace TennisKata
{
    class Program
    {
        private static IServiceProvider serviceProvider;
        static void Main(string[] args)
        {
            // Get service provider
            serviceProvider = ServiceHelper.RegisterServices();
            // Get specific service
            IConsoleService consoleService = serviceProvider.GetService<IConsoleService>();
            IPlayerService playerService = serviceProvider.GetService<IPlayerService>();
            IPointService pointService = serviceProvider.GetService<IPointService>();
            //Play tennis game
            GameManager game = new GameManager(consoleService, playerService, pointService);
            game.PlayGame();
            //Dispose services
            ServiceHelper.DisposeServices(serviceProvider);
        }
    }
}
