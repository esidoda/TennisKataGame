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
    }
}
