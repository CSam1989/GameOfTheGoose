using Application.Common.Interfaces.Models;
using Application.Common.Settings;
using Application.Models;

namespace Application.SpecialSpaces
{
    public class Maze : Space
    {
        private readonly AppConfig _config;

        public Maze(int number, AppConfig config) : base(number)
        {
            _config = config;
        }

        public override void Act(Player player, IGame game)
        {
            player.Position = game.Board.Spaces[_config.SpecialPlaceSettings.MazeToGoSpace];

            game.MessageEvents.OnOutput($" -> S{player.Position.Number}");
        }
    }
}