using Application.Common.Interfaces.Models;
using Application.Common.Interfaces.Strategies;
using Application.Common.Settings;
using Application.Models;

namespace Application.Common.Strategies
{
    public class DeathAct : IAct
    {
        private readonly AppConfig _config;
        private readonly IGame _game;

        public DeathAct(AppConfig config, IGame game)
        {
            _config = config;
            _game = game;
        }

        public string Act(Player player)
        {
            player.Position = _game.Board.Spaces[_config.SpecialPlaceSettings.DeathToGoSpace];

            return "-> Start";
        }
    }
}