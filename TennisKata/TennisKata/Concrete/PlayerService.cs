using System;
using TennisKata.Abstract;
using TennisKata.Models;

namespace TennisKata.Concrete
{
    /// <summary>
    /// Implementation of interface.
    /// </summary>
    class PlayerService : IPlayerService
    {
        /// <summary>
        /// Implements the method <see cref="SetFirstPlayerName(string)"/> of interface.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Player SetFirstPlayerName(string name)
        {
            return new Player(name);
        }

        /// <summary>
        /// Implements the method <see cref="SetSecondPlayerName(string, Player)"/> of interface.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Player SetSecondPlayerName(string name, Player playerB)
        {
            if (name.ToLower() == playerB.Name.ToLower())
                throw new ArgumentException("Players can not have the same name!");
            return new Player(name);
        }

        /// <summary>
        /// Implements the method <see cref="GetGameWinnerPlayer(Player, Player)"/> of interface.
        /// </summary>
        /// <param name="playerA"></param>
        /// <param name="playerB"></param>
        /// <returns></returns>
        public Player GetGameWinnerPlayer(Player playerA, Player playerB)
        {
            if (playerA.Points == Points.Game)
                return playerA;
            else if (playerB.Points == Points.Game)
                return playerB;
            return null;
        }
    }
}
