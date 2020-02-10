using TennisKata.Models;

namespace TennisKata.Abstract
{
    /// <summary>
    /// Service used to manage the methods related to display and read message from Console.
    /// </summary>
    public interface IConsoleService
    {
        /// <summary>
        /// Display the welcome message.
        /// </summary>
        void DisplayWelcomeMessage();

        /// <summary>
        /// Ask for player name.
        /// </summary>
        /// <param name="player">Indiciates if the player is A or B.</param>
        /// <returns>The name of the player typed by the user.</returns>
        string AskForPlayerName(string player);

        /// <summary>
        /// Display a specific message.
        /// </summary>
        /// <param name="message"></param>
        void DisplayMessage(string message);
    }
}
