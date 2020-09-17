using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Application.Common.Interfaces.Models;
using Application.Common.Interfaces.Strategies;
using Application.Common.Settings;
using Application.Models;

namespace Application.Common.Strategies
{
    public class GooseAct: IAct
    {
        private readonly AppConfig _config;
        private readonly IGame _game;

        public GooseAct(AppConfig config, IGame game)
        {
            _config = config;
            _game = game;
        }

        public string Act(Player player)
        {
            if (ActOnSpecialThrow(player, _game)) return $" -> S{player.Position.Number}";

            player.MovePosition(_game.Board);

            return $" -> S{player.Position.Number}"
                   //if player moves again, he/she must act on the new space
                   + player.Position.SpaceAction.Act(player);
        }

        private bool ActOnSpecialThrow(Player player, IGame game)
        {
            foreach (var specialThrow in _config.SpecialPlaceSettings.SpecialGooseThrows)
            {
                if (game.Turn != specialThrow.Turn || !player.CurrentDiceThrow.Contains(specialThrow.Dice1) ||
                    !player.CurrentDiceThrow.Contains(specialThrow.Dice2)) continue;
                player.Position = game.Board.Spaces[specialThrow.PlaceToGo];

                return true;
            }

            return false;
        }
    }
}
