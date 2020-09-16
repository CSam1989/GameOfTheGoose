using Application.Common.Interfaces.Models;
using Application.Common.Settings;
using Application.Models;

namespace Application.SpecialSpaces
{
    public class Bridge : Space
    {
        public Bridge(int number) : base(number)
        {
        }

        public override void Act(Player player, IGame game)
        {
            player.Position = game.Board.Spaces[SpecialPlaceSettings.BridgeToGoSpace];

            game.MessageEvents.OnOutput($" -> S{player.Position.Number}");
        }
    }
}