using System;
using TennisKata.Abstract;
using TennisKata.Models;

namespace TennisKata.Concrete
{
    /// <summary>
    /// Implementation of interface.
    /// </summary>
    class PointService : IPointService
    { 
        /// <summary>
        /// Implements the method <see cref="GetPointWinnerName(Player, Player)"/> of interface.
        /// </summary>
        /// <param name="playerA"></param>
        /// <param name="playerB"></param>
        /// <returns></returns>
        public string GetPointWinnerName(Player playerA, Player playerB)
        {
            return new Random().Next(0, 2) == 0 ? playerA.Name : playerB.Name;
        }

        /// <summary>
        /// Implements the method <see cref="UpdatePlayerPoints(Player, Player, string)"/> of interface.
        /// </summary>
        /// <param name="playerA"></param>
        /// <param name="playerB"></param>
        /// <param name="winningPointPlayerName"></param>
        public void UpdatePlayerPoints(Player playerA, Player playerB, string winningPointPlayerName)
        {
            if (winningPointPlayerName == playerA.Name)
            {
                if (playerA.Points >= Points.Forty && (int)playerA.Points - (int)playerB.Points >= 1)
                {
                    playerA.Points = Points.Game;
                    return;
                }

                if (playerB.Points == Points.Advantage)
                {
                    playerB.Points = Points.Forty;
                }
                else
                {
                    playerA.Points = (Points)((int)playerA.Points + 1);
                }
            }
            else
            {
                if (playerB.Points >= Points.Forty && (int)playerB.Points - (int)playerA.Points >= 1)
                {
                    playerB.Points = Points.Game;
                    return;
                }

                if (playerA.Points == Points.Advantage)
                {
                    playerA.Points = Points.Forty;
                }
                else
                {
                    playerB.Points = (Points)((int)playerB.Points + 1);
                }
            }
        }
    }
}
