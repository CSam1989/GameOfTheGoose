using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Application.Common.Interfaces;
using Application.Common.Settings;

namespace Application.Common.Services
{
    public class WinnerService : IWinnerService
    {
        private readonly IGame _game;
        private readonly IIOService _io;

        public WinnerService(IGame game, IIOService io)
        {
            _game = game;
            _io = io;
        }
        public void PrintWinner()
        {
            var winner = _game.Players.First(p => p.Position.Number == BoardSettings.MaxSpaces);
            
            _io.OutputWithNewLineMessage("Winner".PadLeft((_game.Players.IndexOf(winner) + 1) * 20));
        }
    }
}
