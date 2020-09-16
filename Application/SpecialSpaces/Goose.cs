using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Application.Common.Interfaces;
using Application.Common.Settings;
using Application.Models;

namespace Application.SpecialSpaces
{
    public class Goose: Space
    {
        public Goose(int number) : base(number)
        {
        }

        public override void Act(Player player, IGame game)
        {
            if (!ActOnSpecialThrow(player, game))
                player.MovePosition(game.Board);

            // TODO: Change the Console write to ioService 
            Console.Write($" -> S{player.Position.Number}");
        }

        private bool ActOnSpecialThrow(Player player, IGame game)
        {
            foreach (var specialThrow in SpecialPlaceSettings.SpecialGooseThrows)
            {
                if (game.Turn != specialThrow[0] || !player.CurrentDiceThrow.Contains(specialThrow[1]) ||
                    !player.CurrentDiceThrow.Contains(specialThrow[2])) continue;
                player.Position = game.Board.Spaces[specialThrow[3]];
                //if player moves again, he/she must act on the new space
                player.Position.Act(player, game);
                return true;
            }
            return false;
        }
    }
}
