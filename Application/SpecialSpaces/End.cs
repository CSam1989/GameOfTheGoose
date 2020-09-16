using Application.Common.Interfaces.Models;
using Application.Models;

namespace Application.SpecialSpaces
{
    public class End : Space
    {
        public End(int number) : base(number)
        {
        }

        public override void Act(Player player, IGame game)
        {
            game.HasWinner = true;
        }
    }
}