using System.Collections.Generic;
using Application.Common.Extensions;
using Application.Common.Interfaces.Models;
using Application.Common.Interfaces.services;
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
                    _game.MessageEvents.OnOutputAligned($"skip {player.SkipCount} turn(s)");
                    player.SkipCount--;
                    continue;
                }

                if (player.IsInWell)
                {
                    _game.MessageEvents.OnOutputAligned($"In {nameof(Well)}");
                    continue;
                }

                player.CurrentDiceThrow = _dice.Roll();
                player.MovePosition(_game.Board);
                _game.MessageEvents.OnOutputAligned(
                    $"{player.CurrentDiceThrow.DiceThrowsToString()}: S{player.Position.Number}");

                player.Position.Act(player, _game);
            }

            _game.MessageEvents.OnOutputWithNewline(string.Empty);
        }
    }
}