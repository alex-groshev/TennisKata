namespace TennisKata2
{
    public class NormalScore : Score
    {
        public NormalScore(Player playerOne, Player playerTwo) : base(playerOne, playerTwo)
        {
        }

        public override Score Calculate()
        {
            if (PlayerOne.Points == PlayerTwo.Points)
            {
                return PlayerOne.Points > 2
                    ? (Score)new DeuceScore(PlayerOne, PlayerTwo)
                    : new NormalScore(PlayerOne, PlayerTwo);
            }

            if (PlayerOne.Points > 3 || PlayerTwo.Points > 3)
            {
                return System.Math.Abs(PlayerOne.Points - PlayerTwo.Points) == 1
                     ? (Score)new AdvantageScore(PlayerOne, PlayerTwo)
                     : new WinScore(PlayerOne, PlayerTwo);
            }

            return new NormalScore(PlayerOne, PlayerTwo);
        }

        public override string ToString()
        {
            return PlayerOne.Points == PlayerTwo.Points
                ? $"{ScoreNames[PlayerOne.Points]}-All"
                : $"{ScoreNames[PlayerOne.Points]}-{ScoreNames[PlayerTwo.Points]}";
        }
    }
}
