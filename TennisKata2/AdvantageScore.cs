namespace TennisKata2
{
    public class AdvantageScore : Score
    {
        public AdvantageScore(Player playerOne, Player playerTwo) : base(playerOne, playerTwo)
        {
        }

        public override Score Calculate()
        {
            return PlayerOne.Points == PlayerTwo.Points
                ? (Score)new DeuceScore(PlayerOne, PlayerTwo)
                : new WinScore(PlayerOne, PlayerTwo);
        }

        public override string ToString()
        {
            return PlayerOne.Points > PlayerTwo.Points
                ? $"Advantage {PlayerOne.Name}"
                : $"Advantage {PlayerTwo.Name}";
        }
    }
}
