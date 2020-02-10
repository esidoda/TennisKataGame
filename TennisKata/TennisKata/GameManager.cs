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
    }
}
