using NUnit.Framework;

namespace TennisKata1
{
    [TestFixture]
    public class Tests
    {
        [TestCase(0, 0, "Love-All")]
        [TestCase(1, 1, "Fifteen-All")]
        [TestCase(2, 2, "Thirty-All")]
        [TestCase(3, 3, "Deuce")]
        [TestCase(4, 4, "Deuce")]
        [TestCase(1, 0, "Fifteen-Love")]
        [TestCase(0, 1, "Love-Fifteen")]
        [TestCase(2, 0, "Thirty-Love")]
        [TestCase(0, 2, "Love-Thirty")]
        [TestCase(3, 0, "Forty-Love")]
        [TestCase(0, 3, "Love-Forty")]
        [TestCase(4, 0, "Win for player1")]
        [TestCase(0, 4, "Win for player2")]
        [TestCase(2, 1, "Thirty-Fifteen")]
        [TestCase(1, 2, "Fifteen-Thirty")]
        [TestCase(3, 1, "Forty-Fifteen")]
        [TestCase(1, 3, "Fifteen-Forty")]
        [TestCase(4, 1, "Win for player1")]
        [TestCase(1, 4, "Win for player2")]
        [TestCase(3, 2, "Forty-Thirty")]
        [TestCase(2, 3, "Thirty-Forty")]
        [TestCase(4, 2, "Win for player1")]
        [TestCase(2, 4, "Win for player2")]
        [TestCase(4, 3, "Advantage player1")]
        [TestCase(3, 4, "Advantage player2")]
        [TestCase(5, 4, "Advantage player1")]
        [TestCase(4, 5, "Advantage player2")]
        [TestCase(15, 14, "Advantage player1")]
        [TestCase(14, 15, "Advantage player2")]
        [TestCase(6, 4, "Win for player1")]
        [TestCase(4, 6, "Win for player2")]
        [TestCase(16, 14, "Win for player1")]
        [TestCase(14, 16, "Win for player2")]
        public void Should_return_score_correctly(int p1Score, int p2Score, string result)
        {
            var p1 = new Player("player1");
            var p2 = new Player("player2");
            var game = new Game();

            for (var i = 1; i <= p1Score; i++)
            {
                p1.WinScore();
            }

            for (var i = 1; i <= p2Score; i++)
            {
                p2.WinScore();
            }

            Assert.AreEqual(result, game.Score(p1, p2));
        }
    }
}
