using System.Linq;
using Application.Common.Interfaces.Models;
using Application.Common.Interfaces.Strategies;
using Application.Common.Settings;
using Application.Models;

namespace Application.Common.Strategies
{
    public class WellAct : IAct
    {
        private readonly AppConfig _config;
        private readonly IGame _game;

        public WellAct(AppConfig config, IGame game)
        {
            _config = config;
            _game = game;
        }

        public string Act(Player player)
        {
            player.IsInWell = true;
            _game.PlayersInWell.Add(player);

            if (_game.PlayersInWell.Count > 1)
            {
                var firstPlayerInWell = _game.PlayersInWell.First();
                firstPlayerInWell.IsInWell = false;
                _game.PlayersInWell.Remove(firstPlayerInWell);
            }

            ;

            return " -> Well";
        }
    }
}