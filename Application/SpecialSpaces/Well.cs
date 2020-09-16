using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Application.Common.Interfaces;
using Application.Models;

namespace Application.SpecialSpaces
{
    public class Well: Space
    {
        public Well(int number) : base(number)
        {
        }

        public override void Act(Player player, IGame game)
        {
            player.IsInWell = true;
            game.PlayersInWell.Add(player);

            // TODO: Change the Console write to ioService 
            Console.Write($" -> {this.GetType().Name}");

            if (game.PlayersInWell.Count <= 1) return;

            var firstPlayerInWell = game.PlayersInWell.First();
            firstPlayerInWell.IsInWell = false;
            game.PlayersInWell.Remove(firstPlayerInWell);
        }
    }
}
