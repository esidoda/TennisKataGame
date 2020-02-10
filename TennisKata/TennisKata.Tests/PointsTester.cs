using Microsoft.VisualStudio.TestTools.UnitTesting;
using TennisKata.Abstract;
using TennisKata.Helpers;
using TennisKata.Models;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace TennisKata.Testing
{
    /// <summary>
    /// Class responsible to methods related with Points.
    /// </summary>
    [TestClass]
    public class PointsTester
    {
        /// <summary>
        /// Checks the displayed message if the players are deuce.
        /// </summary>
        [TestMethod]
        public void DisplayPoints_Deuce()
        {
            Player playerA = new Player("PlayerA")
            {
                Points = Points.Forty
            };

            Player playerB = new Player("PlayerB")
            {
                Points = Points.Forty
            };

            ServiceProvider serviceProvider = ServiceHelper.RegisterServices();
            IConsoleService consoleService = serviceProvider.GetService<IConsoleService>();
            consoleService.DisplayPlayersPoints(playerA, playerB);
        }

        /// <summary>
        /// Checks the displayed message if Player A is in advantage.
        /// </summary>
        [TestMethod]
        public void DisplayPoints_AdvantagePlayerA()
        {
            Player playerA = new Player("PlayerA")
            {
                Points = Points.Advantage
            };

            Player playerB = new Player("PlayerB")
            {
                Points = Points.Forty
            };

            ServiceProvider serviceProvider = ServiceHelper.RegisterServices();
            IConsoleService consoleService = serviceProvider.GetService<IConsoleService>();
            consoleService.DisplayPlayersPoints(playerA, playerB);
        }

        /// <summary>
        /// Checks the displayed message if Player B is in advantage.
        /// </summary>
        [TestMethod]
        public void DisplayPoints_AdvantagePlayerB()
        {
            Player playerA = new Player("PlayerA")
            {
                Points = Points.Forty
            };

            Player playerB = new Player("PlayerB")
            {
                Points = Points.Advantage
            };

            ServiceProvider serviceProvider = ServiceHelper.RegisterServices();
            IConsoleService consoleService = serviceProvider.GetService<IConsoleService>();
            consoleService.DisplayPlayersPoints(playerA, playerB);
        }
    }
}
