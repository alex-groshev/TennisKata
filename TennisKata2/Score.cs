using System.Collections.Generic;

namespace TennisKata2
{
    public abstract class Score
    {
        protected readonly Dictionary<int, string> ScoreNames = new Dictionary<int, string>
            {
                {0, "Love"}, {1, "Fifteen"}, {2, "Thirty"}, {3, "Forty"}
            };

        protected Player PlayerOne { get; }

        protected Player PlayerTwo { get; }

        protected Score(Player playerOne, Player playerTwo)
        {
            PlayerOne = playerOne;
            PlayerTwo = playerTwo;
        }

        public abstract Score Calculate();
    }
}
