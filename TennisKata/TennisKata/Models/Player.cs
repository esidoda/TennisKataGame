using System;

namespace TennisKata.Models
{
    public class Player
    {
        public string Name { get; private set; }

        public Points Points { get; set; }

        public Player(string name)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Players name can not be empty, null or white spaces only");
            Name = name;
        }

        public Player()
        {

        }
    }
}
