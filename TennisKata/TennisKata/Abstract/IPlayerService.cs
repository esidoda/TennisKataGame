using TennisKata.Models;

namespace TennisKata.Abstract
{
    /// <summary>
    /// Service used to manage the methods related with player.
    /// </summary>
    public interface IPlayerService
    {
        /// <summary>
        /// Set first player name.
        /// </summary>
        /// <param name="name">The name of the player.</param>
        /// <returns></returns>
        Player SetFirstPlayerName(string name);

        /// <summary>
        /// Set second player name.
        /// </summary>
        /// <param name="name">The name of the player.</param>
        /// <returns></returns>
        Player SetSecondPlayerName(string name, Player playerA);
    }
}
