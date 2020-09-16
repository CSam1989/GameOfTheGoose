using Application.Common.Interfaces.Models;
using Application.Common.Settings;
using Application.Models;

namespace Application.SpecialSpaces
{
    public class Death : Space
    {
        public Death(int number) : base(number)
        {
        }

        public override void Act(Player player, IGame game)
        {
            player.Position = game.Board.Spaces[SpecialPlaceSettings.DeathToGoSpace];

            game.MessageEvents.OnOutput("-> Start");
        }
    }
}