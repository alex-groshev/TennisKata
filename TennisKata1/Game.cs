using System.Collections.Generic;

namespace TennisKata1
{
    public class Game
    {
        private readonly Dictionary<int, string> _scoreNames = new Dictionary<int, string>
        {
            {0, "Love"}, {1, "Fifteen"}, {2, "Thirty"}, {3, "Forty"}
        };

        public string Score(Player p1, Player p2)
        {
            if (p1.Points == p2.Points)
                return p1.Points < 3 ? $"{_scoreNames[p1.Points]}-All" : "Deuce";

            var diff = p1.Points - p2.Points;
            if (p1.Points > 3 || p2.Points > 3)
            {
                if (diff > 1)
                    return $"Win for {p1.Name}";
                if (diff < -1)
                    return $"Win for {p2.Name}";
            }

            if (p1.Points < 3 || p2.Points < 3)
                return $"{_scoreNames[p1.Points]}-{_scoreNames[p2.Points]}";

            return diff > 0 ? $"Advantage {p1.Name}" : $"Advantage {p2.Name}";
        }
    }
}
