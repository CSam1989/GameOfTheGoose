using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Application.Common.Extensions;
using Application.Common.Interfaces;
using Application.Common.Interfaces.Models;
using Application.Common.Interfaces.services;
using Application.Common.Settings;
using Application.Models;
using Application.SpecialSpaces;

namespace Application.Common.Services
{
    public class GameService : IGameService
    {
        private readonly IDiceService _dice;
        private readonly IGame _game;

        public GameService(IDiceService dice, IGame game)
        {
            _dice = dice;
            _game = game;
        }

        public void MovePieces(ICollection<Player> players)
        {
            foreach (var player in players)
            {
                if (player.SkipCount > 0)
                {
                    _game.MessageEvents.OnOutput($"skip {player.SkipCount} turn(s)".PadLeft(20));
                    player.SkipCount--;
                    continue;
                }

                if (player.IsInWell)
                {
                    _game.MessageEvents.OnOutput($"In {nameof(Well)}".PadLeft(20));
                    continue;
                }

                player.CurrentDiceThrow = _dice.Roll();
                player.MovePosition(_game.Board);
                _game.MessageEvents.OnOutput($"{player.CurrentDiceThrow.DiceThrowsToString()}: S{player.Position.Number}".PadLeft(20));

                player.Position.Act(player, _game);
            }
            _game.MessageEvents.OnOutputWithNewline(string.Empty);
        }
    }
}
