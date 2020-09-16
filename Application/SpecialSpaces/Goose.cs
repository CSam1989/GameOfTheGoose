using System.Linq;
using Application.Common.Interfaces.Models;
using Application.Common.Settings;
using Application.Models;

namespace Application.SpecialSpaces
{
    public class Goose : Space
    {
        private readonly AppConfig _config;

        public Goose(int number, AppConfig config) : base(number)
        {
            _config = config;
        }

        public override string Act(Player player, IGame game)
        {
            if (ActOnSpecialThrow(player, game)) return $" -> S{player.Position.Number}";

            player.MovePosition(game.Board);

            return $" -> S{player.Position.Number}"
                   //if player moves again, he/she must act on the new space
                   + player.Position.Act(player, game);

        }

        private bool ActOnSpecialThrow(Player player, IGame game)
        {
            foreach (var specialThrow in _config.SpecialPlaceSettings.SpecialGooseThrows)
            {
                if (game.Turn != specialThrow[0] || !player.CurrentDiceThrow.Contains(specialThrow[1]) ||
                    !player.CurrentDiceThrow.Contains(specialThrow[2])) continue;
                player.Position = game.Board.Spaces[specialThrow[3]];

                return true;
            }

            return false;
        }
    }
}