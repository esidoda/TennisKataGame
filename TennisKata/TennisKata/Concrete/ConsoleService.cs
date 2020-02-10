using System;
using TennisKata.Abstract;
using TennisKata.Models;

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

        /// <summary>
        /// Implements the method <see cref="DisplayPlayersPoints(Player, Player)"/> of interface.
        /// </summary>
        /// <param name="playerA"></param>
        /// <param name="playerB"></param>
        public void DisplayPlayersPoints(Player playerA, Player playerB)
        {
            if (playerA.Points == Points.Forty && playerB.Points == Points.Forty)
            {
                Console.WriteLine("DEUCE!");
            }
            else if (playerA.Points == Points.Advantage)
            {
                Console.WriteLine($"ADVANTAGE {playerA.Name}!");
            }
            else if (playerB.Points == Points.Advantage)
            {
                Console.WriteLine($"ADVANTAGE {playerB.Name}!");
            }

            Console.WriteLine(
                $@"
*********************************
{playerA.Name} - {playerA.Points}
{playerB.Name} - {playerB.Points}
*********************************");
        }

        /// <summary>
        /// Implements the method <see cref="AskToPlay()"/> of interface.
        /// </summary>
        public void AskToPlay()
        {
            Console.WriteLine("Press any to key to win the point...");
            Console.ReadKey();
        }

        /// <summary>
        /// Implements the method <see cref="Clear()"/> of interface.
        /// </summary>
        public void Clear()
        {
            Console.Clear();
        }
    }
}
