namespace Application.Models
{
    public class Player
    {
        public Player()
        {
            CurrentDiceThrow = new[] {0, 0}; //start of game, player hasn't thrown yet
        }

        public string Name { get; set; }
        public int[] CurrentDiceThrow { get; set; }
        public Space Position { get; set; }
        public int SkipCount { get; set; }
        public bool IsInWell { get; set; }
    }
}