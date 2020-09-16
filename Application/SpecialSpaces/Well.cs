using System.Linq;
using Application.Common.Interfaces.Models;
using Application.Common.Settings;
using Application.Models;

namespace Application.SpecialSpaces
{
    public class Well : Space
    {
        public Well(int number, AppConfig config) : base(number)
        {
        }

        public override string Act(Player player, IGame game)
        {
            player.IsInWell = true;
            game.PlayersInWell.Add(player);

            if (game.PlayersInWell.Count > 1)
            {
                var firstPlayerInWell = game.PlayersInWell.First();
                firstPlayerInWell.IsInWell = false;
                game.PlayersInWell.Remove(firstPlayerInWell);
            };

            return $" -> {GetType().Name}";
        }
    }
}