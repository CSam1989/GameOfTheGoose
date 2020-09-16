using System.Linq;
using Application.Common.Interfaces.Models;
using Application.Models;

namespace Application.SpecialSpaces
{
    public class Well : Space
    {
        public Well(int number) : base(number)
        {
        }

        public override void Act(Player player, IGame game)
        {
            player.IsInWell = true;
            game.PlayersInWell.Add(player);

            game.MessageEvents.OnOutput($" -> {GetType().Name}");

            if (game.PlayersInWell.Count <= 1) return;

            var firstPlayerInWell = game.PlayersInWell.First();
            firstPlayerInWell.IsInWell = false;
            game.PlayersInWell.Remove(firstPlayerInWell);
        }
    }
}