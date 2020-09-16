using Application.Common.Interfaces.Models;
using Application.Common.Settings;
using Application.Models;

namespace Application.SpecialSpaces
{
    public class End : Space
    {
        public End(int number, AppConfig config) : base(number)
        {
        }

        public override void Act(Player player, IGame game)
        {
            game.HasWinner = true;
        }
    }
}