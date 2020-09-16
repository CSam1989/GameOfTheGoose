using Application.Common.Interfaces.Models;
using Application.Common.Settings;
using Application.Models;

namespace Application.SpecialSpaces
{
    public class Prison : Space
    {
        private readonly AppConfig _config;

        public Prison(int number, AppConfig config) : base(number)
        {
            _config = config;
        }

        public override void Act(Player player, IGame game)
        {
            player.SkipCount = _config.SpecialPlaceSettings.PrisonSkipCount;

            game.MessageEvents.OnOutput($"-> Skip {player.SkipCount}");
        }
    }
}