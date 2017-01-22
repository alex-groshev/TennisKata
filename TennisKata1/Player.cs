namespace TennisKata1
{
    public class Player
    {
        public string Name { get; }
        public int Points { get; private set; }

        public Player(string name)
        {
            Name = name;
        }

        public void WinScore()
        {
            Points++;
        }
    }
}
