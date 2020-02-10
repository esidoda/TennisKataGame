using System;
using TennisKata.Abstract;

namespace TennisKata.Concrete
{
    /// <summary>
    /// Implementation of interface.
    /// </summary>
    public class ConsoleService : IConsoleService
    {
        /// <summary>
        /// Implements the method <see cref="DisplayWelcomeMessage()"/> of interface.
        /// </summary>
        public void DisplayWelcomeMessage()
        {
            Console.WriteLine($@"
********************************* 
Welcome to Tennis Game 
*********************************");
        }

        /// <summary>
        /// Implements the method <see cref="AskForPlayerName(string)"/> of interface.
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public string AskForPlayerName(string player)
        {
            Console.WriteLine($"Please enter the name of player {player}:");
            var name = Console.ReadLine();
            return name;
        }

        /// <summary>
        /// Implements the method <see cref="DisplayMessage(string)"/> of interface.
        /// </summary>
        /// <param name="message"></param>
        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
