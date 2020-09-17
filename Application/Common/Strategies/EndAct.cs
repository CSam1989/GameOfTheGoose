using Application.Common.Interfaces.Models;
using Application.Common.Interfaces.Strategies;
using Application.Common.Settings;
using Application.Models;

namespace Application.Common.Strategies
{
    public class EndAct : IAct
    {
        private readonly AppConfig _config;
        private readonly IGame _game;

        public EndAct(AppConfig config, IGame game)
        {
            _config = config;
            _game = game;
        }

        public string Act(Player player)
        {
            _game.HasWinner = true;
            return string.Empty;
        }
    }
}