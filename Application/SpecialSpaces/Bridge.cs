using Application.Common.Interfaces.Models;
using Application.Common.Settings;
using Application.Models;

namespace Application.SpecialSpaces
{
    public class Bridge : Space
    {
        private readonly AppConfig _config;

        public Bridge(int number, AppConfig config) : base(number)
        {
            _config = config;
        }

        public override void Act(Player player, IGame game)
        {
            player.Position = game.Board.Spaces[_config.SpecialPlaceSettings.BridgeToGoSpace];

            game.MessageEvents.OnOutput($" -> S{player.Position.Number}");
        }
    }
}