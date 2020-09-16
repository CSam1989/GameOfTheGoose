using Application.Common.Interfaces.Models;
using Application.Common.Settings;
using Application.Models;

namespace Application.SpecialSpaces
{
    public class Inn : Space
    {
        private readonly AppConfig _config;

        public Inn(int number, AppConfig config) : base(number)
        {
            _config = config;
        }

        public override string Act(Player player, IGame game)
        {
            player.SkipCount = _config.SpecialPlaceSettings.InnSkipCount;

            return $"-> Skip {player.SkipCount}";
        }
    }
}