using Application.Common.Interfaces.Models;
using Application.Common.Interfaces.Strategies;
using Application.Common.Settings;
using Application.Models;

namespace Application.Common.Strategies
{
    public class PrisonAct : IAct
    {
        private readonly AppConfig _config;
        private readonly IGame _game;

        public PrisonAct(AppConfig config, IGame game)
        {
            _config = config;
            _game = game;
        }

        public string Act(Player player)
        {
            player.SkipCount = _config.SpecialPlaceSettings.PrisonSkipCount;

            return $"-> Skip {player.SkipCount}";
        }
    }
}