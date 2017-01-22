namespace TennisKata2
{
    public class DeuceScore : Score
    {
        public DeuceScore(Player playerOne, Player playerTwo) : base(playerOne, playerTwo)
        {
        }

        public override Score Calculate()
        {
            return new AdvantageScore(PlayerOne, PlayerTwo);
        }

        public override string ToString()
        {
            return "Deuce";
        }
    }
}
