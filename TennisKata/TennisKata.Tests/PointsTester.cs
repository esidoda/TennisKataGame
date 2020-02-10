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

        /// <summary>
        /// Checks if the winner of the game is player A after winning all points.
        /// </summary>
        [TestMethod]
        public void Points_AlwaysWinsPlayerA()
        {
            Player playerA = new Player("PlayerA");
            Player playerB = new Player("PlayerB");
            Player winner = new Player();
            ServiceProvider serviceProvider = ServiceHelper.RegisterServices();
            IPointService pointService = serviceProvider.GetService<IPointService>();
            IPlayerService playerService = serviceProvider.GetService<IPlayerService>();
            while (true)
            {
                string pointWinnerName = playerA.Name;
                //Update player points points
                pointService.UpdatePlayerPoints(playerA, playerB, pointWinnerName);
                //Get Winner Player
                winner = playerService.GetGameWinnerPlayer(playerA, playerB);
                if (winner != null)
                {
                    Assert.AreEqual(playerA.Name, winner.Name);
                    break;
                }
            }

        }

        /// <summary>
        /// Checks if the winner of the game is player B after winning all points.
        /// </summary>
        [TestMethod]
        public void Points_AlwaysWinsPlayerB()
        {
            Player playerA = new Player("PlayerA");
            Player playerB = new Player("PlayerB");
            Player winner = new Player();
            ServiceProvider serviceProvider = ServiceHelper.RegisterServices();
            IPointService pointService = serviceProvider.GetService<IPointService>();
            IPlayerService playerService = serviceProvider.GetService<IPlayerService>();
            while (true)
            {
                string pointWinnerName = playerB.Name;
                //Update player points points
                pointService.UpdatePlayerPoints(playerA, playerB, pointWinnerName);
                //Get Winner Player
                winner = playerService.GetGameWinnerPlayer(playerA, playerB);
                if (winner != null)
                {
                    Assert.AreEqual(playerB.Name, winner.Name);
                    break;
                }
            }

        }

        /// <summary>
        /// Checks if the winner of the game is player A after several increase of points.
        /// </summary>
        [TestMethod]
        public void Points_UpdatePoints_PlayerA_WinsTheGame()
        {
            ServiceProvider serviceProvider = ServiceHelper.RegisterServices();
            IPointService pointService = serviceProvider.GetService<IPointService>();
            Player playerA = new Player("Player A");
            Player playerB = new Player("Player B");

            pointService.UpdatePlayerPoints(playerA, playerB, playerA.Name);
            Assert.AreEqual(Points.Fifteen, playerA.Points);

            pointService.UpdatePlayerPoints(playerA, playerB, playerB.Name);
            Assert.AreEqual(Points.Fifteen, playerB.Points);

            pointService.UpdatePlayerPoints(playerA, playerB, playerA.Name);
            Assert.AreEqual(Points.Thirty, playerA.Points);

            pointService.UpdatePlayerPoints(playerA, playerB, playerB.Name);
            Assert.AreEqual(Points.Thirty, playerB.Points);

            pointService.UpdatePlayerPoints(playerA, playerB, playerA.Name);
            Assert.AreEqual(Points.Forty, playerA.Points);

            pointService.UpdatePlayerPoints(playerA, playerB, playerA.Name);
            Assert.AreEqual(Points.Game, playerA.Points);
            Assert.AreEqual(Points.Thirty, playerB.Points);
        }

        /// <summary>
        /// Checks if the winner of the game is player A after several increase of points.
        /// </summary>

        [TestMethod]
        public void Points_UpdatePoints_PlayerB_WinsTheGame()
        {
            ServiceProvider serviceProvider = ServiceHelper.RegisterServices();
            IPointService pointService = serviceProvider.GetService<IPointService>();
            Player playerA = new Player("Player A");
            Player playerB = new Player("Player B");

            pointService.UpdatePlayerPoints(playerA, playerB, playerA.Name);
            Assert.AreEqual(Points.Fifteen, playerA.Points);

            pointService.UpdatePlayerPoints(playerA, playerB, playerB.Name);
            Assert.AreEqual(Points.Fifteen, playerB.Points);

            pointService.UpdatePlayerPoints(playerA, playerB, playerA.Name);
            Assert.AreEqual(Points.Thirty, playerA.Points);

            pointService.UpdatePlayerPoints(playerA, playerB, playerB.Name);
            Assert.AreEqual(Points.Thirty, playerB.Points);

            pointService.UpdatePlayerPoints(playerA, playerB, playerB.Name);
            Assert.AreEqual(Points.Forty, playerB.Points);

            pointService.UpdatePlayerPoints(playerA, playerB, playerB.Name);
            Assert.AreEqual(Points.Game, playerB.Points);
            Assert.AreEqual(Points.Thirty, playerA.Points);
        }

        /// <summary>
        /// Checks the case advantage between two players.
        /// </summary>
        [TestMethod]
        public void Points_UpdatePoints_CaseOfAdvantage()
        {
            ServiceProvider serviceProvider = ServiceHelper.RegisterServices();
            IPointService pointService = serviceProvider.GetService<IPointService>();
            Player playerA = new Player("Player A");
            Player playerB = new Player("Player B");

            pointService.UpdatePlayerPoints(playerA, playerB, playerA.Name);
            Assert.AreEqual(Points.Fifteen, playerA.Points);

            pointService.UpdatePlayerPoints(playerA, playerB, playerA.Name);
            Assert.AreEqual(Points.Thirty, playerA.Points);

            pointService.UpdatePlayerPoints(playerA, playerB, playerB.Name);
            Assert.AreEqual(Points.Fifteen, playerB.Points);

            pointService.UpdatePlayerPoints(playerA, playerB, playerB.Name);
            Assert.AreEqual(Points.Thirty, playerB.Points);

            pointService.UpdatePlayerPoints(playerA, playerB, playerA.Name);
            Assert.AreEqual(Points.Forty, playerA.Points);

            pointService.UpdatePlayerPoints(playerA, playerB, playerB.Name);
            Assert.AreEqual(Points.Forty, playerB.Points);

            //Player A takes advantage
            pointService.UpdatePlayerPoints(playerA, playerB, playerA.Name);
            Assert.AreEqual(Points.Advantage, playerA.Points);
            //Point for Player B, it removes the advantage from player A
            pointService.UpdatePlayerPoints(playerA, playerB, playerB.Name);
            Assert.AreEqual(Points.Forty, playerA.Points);
            //Point for Player B
            pointService.UpdatePlayerPoints(playerA, playerB, playerB.Name);
            Assert.AreEqual(Points.Advantage, playerB.Points);
            //Player B wins the game
            pointService.UpdatePlayerPoints(playerA, playerB, playerB.Name);
            Assert.AreEqual(Points.Game, playerB.Points);
        }

    }
}