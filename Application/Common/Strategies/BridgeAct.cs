using Application.Common.Interfaces.Models;
using Application.Common.Interfaces.Strategies;
using Application.Common.Settings;
using Application.Models;

namespace Application.Common.Strategies
{
    public class BridgeAct : IAct
    {
        private readonly AppConfig _config;
        private readonly IGame _game;

        public BridgeAct(AppConfig config, IGame game)
        {
            _config = config;
            _game = game;
        }

        public string Act(Player player)
        {
            player.Position = _game.Board.Spaces[_config.SpecialPlaceSettings.BridgeToGoSpace];

            return $" -> S{player.Position.Number}";
        }
    }
}