using System.Linq;
using Application.Common.Settings;

namespace Application.Models
{
    public class Player
    {
        private readonly AppConfig _config;

        public Player(AppConfig config)
        {
            _config = config;
            CurrentDiceThrow = new[] {0, 0}; //start of game, player hasn't thrown yet
        }

        public string Name { get; set; }
        public int[] CurrentDiceThrow { get; set; }
        public Space Position { get; set; }
        public int SkipCount { get; set; }
        public bool IsInWell { get; set; }

        public void MovePosition(Board board)
        {
            var indexNewPosition = Position.Number + CurrentDiceThrow.Sum();

            //Extra logic for when piece is above the end space
            if (indexNewPosition >= _config.Settings.MaxSpaces)
                indexNewPosition -= (indexNewPosition - _config.Settings.MaxSpaces) * 2;

            Position = board.Spaces[indexNewPosition];
        }
    }
}