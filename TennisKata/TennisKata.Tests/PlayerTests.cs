using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TennisKata.Models;

namespace TennisKata.Testing
{
    /// <summary>
    /// Class responsible to test player object.
    /// </summary>
    [TestClass]
    public class PlayerTester
    {
        /// <summary>
        /// Checks if the excepted exception is throwed when player's name is empty.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Players name can not be empty, null or white spaces only")]
        public void PlayerName_IsEmpty()
        {
            Player player = new Player("");
        }

        /// <summary>
        /// Checks if the excepted exception is throwed when player's name is null.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Players name can not be empty, null or white spaces only")]

        public void PlayerName_IsNull()
        {
            Player player = new Player(null);
        }

        /// <summary>
        /// Checks if the excepted exception is throwed when player's name white space.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Players name can not be empty, null or white spaces only")]

        public void PlayerName_IsWhiteSpace()
        {
            Player player = new Player("   ");
        }
    }
}
