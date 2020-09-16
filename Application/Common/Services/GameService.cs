using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Application.Common.Extensions;
using Application.Common.Interfaces;
using Application.Common.Settings;
using Application.Models;

namespace Application.Common.Services
{
    public class GameService : IGameService
    {
        private readonly IDiceService _dice;
        private readonly IIOService _io;
        private readonly IGame _game;

        public GameService(IDiceService dice, IIOService io, IGame game)
        {
            _dice = dice;
            _io = io;
            _game = game;
        }

        public void MovePieces(ICollection<Player> players)
        {
            foreach (var player in players)
            {
                if (player.SkipCount > 0)
                {
                    _io.OutputMessage($"skip {player.SkipCount} turn(s)".PadLeft(20));
                    player.SkipCount--;
                    continue;
                }

                player.CurrentDiceThrow = _dice.Roll();
                player.MovePosition(_game.Board);
                _io.OutputMessage($"{player.CurrentDiceThrow.DiceThrowsToString()}: S{player.Position.Number}".PadLeft(20));

                player.Position.Act(player, _game);
            }
            _io.OutputWithNewLineMessage(string.Empty);
        }
    }
}
