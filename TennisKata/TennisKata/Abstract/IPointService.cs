using TennisKata.Models;

namespace TennisKata.Abstract
{
    /// <summary>
    /// Service used to manage the methods related with points.
    /// </summary>
    public interface IPointService
    {
        /// <summary>
        /// Gets the name of the player who wins the current point.
        /// </summary>
        /// <param name="playerA"></param>
        /// <param name="playerB"></param>
        /// <returns></returns>
        string GetPointWinnerName(Player playerA, Player playerB);

        /// <summary>
        /// Updates player points depending on the player name who won the current point.
        /// </summary>
        /// <param name="playerA"></param>
        /// <param name="playerB"></param>
        /// <param name="winningPointPlayerName"></param>
        void UpdatePlayerPoints(Player playerA, Player playerB, string winningPointPlayerName);
    }
}
