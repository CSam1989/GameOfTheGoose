using Application.Common.Interfaces.Models;
using Application.Common.Settings;
using Application.Models;

namespace Application.SpecialSpaces
{
    public class Death : Space
    {
        private readonly AppConfig _config;

        public Death(int number, AppConfig config) : base(number)
        {
            _config = config;
        }

        public override string Act(Player player, IGame game)
        {
            player.Position = game.Board.Spaces[_config.SpecialPlaceSettings.DeathToGoSpace];

            return "-> Start";
        }
    }
}