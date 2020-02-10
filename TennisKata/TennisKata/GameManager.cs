using System;
using TennisKata.Abstract;
using TennisKata.Models;

namespace TennisKata
{
    /// <summary>
    /// Class to manage the game.
    /// </summary>
    public class GameManager
    {
        #region Fields
        private readonly IConsoleService consoleService;
        private readonly IPlayerService playerService;
        private readonly IPointService pointService;
        private Player playerA;
        private Player playerB;

        #endregion

        #region Constructor

        /// <summary>
        /// Creates a new instance of the <see cref="GameManager"/> class.
        /// </summary>
        /// <param name="consoleService">The console service that will be used by the class.</param>
        /// <param name="playerService">The player service that will be used by the class.</param>
        /// <param name="pointService">The point service that will be used by the class.</param>
        public GameManager(IConsoleService consoleService, IPlayerService playerService, IPointService pointService)
        {
            this.consoleService = consoleService ?? throw new ArgumentNullException("consoleService");
            this.playerService = playerService ?? throw new ArgumentNullException("playerService");
            this.pointService = pointService ?? throw new ArgumentNullException("pointService");
        }

        #endregion

        #region Methods

        /// <summary>
        /// Method to manage tennis game.
        /// </summary>
        public void PlayGame()
        {
            try
            {
                //Display welcome message
                consoleService.DisplayWelcomeMessage();
                //Get players name
                playerA = playerService.SetFirstPlayerName(consoleService.AskForPlayerName("A"));
                playerB = playerService.SetSecondPlayerName(consoleService.AskForPlayerName("B"), playerA);

                while (true)
                {
                    //Display players points, ask them to play
                    consoleService.DisplayPlayersPoints(playerA, playerB);
                    consoleService.AskToPlay();
                    consoleService.Clear();

                    //Get point winner player name and display it
                    string pointWinnerName = pointService.GetPointWinnerName(playerA, playerB);
                    consoleService.DisplayMessage($"{pointWinnerName} won the point");
                }
            }

            catch (Exception ex)
            {
                consoleService.DisplayMessage(ex.Message);
            }


        }
        #endregion
    }
}
