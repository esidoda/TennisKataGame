using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TennisKata.Abstract;
using TennisKata.Helpers;
using Microsoft.Extensions.DependencyInjection;
using TennisKata.Models;

namespace TennisKata.Testing
{
    /// <summary>
    /// Class responsible to methods related with GameManager class.
    /// </summary>
    [TestClass]
    public class GameManagerTests
    {
        /// <summary>
        /// Checks if the excepted exception is throwed when console service is null.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GameManager_ConsoleServiceNull()
        {
            ServiceProvider serviceProvider = ServiceHelper.RegisterServices();
            // Get service provider
            IConsoleService consoleService = null;
            IPlayerService playerService = serviceProvider.GetService<IPlayerService>();
            IPointService pointService = serviceProvider.GetService<IPointService>();
            //Play tennis game
            GameManager game = new GameManager(consoleService, playerService, pointService);
        }

        /// <summary>
        /// Checks if the excepted exception is throwed when player service is null.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GameManager_PlayerServiceNull()
        {
            ServiceProvider serviceProvider = ServiceHelper.RegisterServices();
            // Get service provider
            IConsoleService consoleService = serviceProvider.GetService<IConsoleService>();
            IPlayerService playerService = null;
            IPointService pointService = serviceProvider.GetService<IPointService>();
            //Play tennis game
            GameManager game = new GameManager(consoleService, playerService, pointService);
        }

        /// <summary>
        /// Checks if the excepted exception is throwed when point service is null.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GameManager_PointServiceNull()
        {
            ServiceProvider serviceProvider = ServiceHelper.RegisterServices();
            // Get service provider
            IConsoleService consoleService = serviceProvider.GetService<IConsoleService>();
            IPlayerService playerService = serviceProvider.GetService<IPlayerService>();
            IPointService pointService = null;
            //Play tennis game
            GameManager game = new GameManager(consoleService, playerService, pointService);
        }

        /// <summary>
        /// Checks if the excepted exception is throwed when players name are the same.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Players can not have the same name!")]
        public void GameManager_PlayersWithSameName()
        {
            ServiceProvider serviceProvider = ServiceHelper.RegisterServices();
            IPlayerService playerService = serviceProvider.GetService<IPlayerService>();
            string namePlayerA = "Esi";
            string namePlayerB = "Esi";
            Player playerA = playerService.SetFirstPlayerName(namePlayerA);
            Player playerB = playerService.SetSecondPlayerName(namePlayerB, playerA);
        }
    }
}
