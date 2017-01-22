namespace TennisKata2
{
    public class WinScore : Score
    {
        public WinScore(Player playerOne, Player playerTwo) : base(playerOne, playerTwo)
        {
        }

        public override Score Calculate()
        {
            return this;
        }

        public override string ToString()
        {
            return PlayerOne.Points > PlayerTwo.Points
                ? $"Win for {PlayerOne.Name}"
                : $"Win for {PlayerTwo.Name}";
        }
    }
}
