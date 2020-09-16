using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Application.Common.Interfaces;
using Application.Common.Interfaces.Models;
using Application.Common.Interfaces.Services;
using Application.Common.Settings;

namespace Application.Common.Services
{
    public class WinnerService : IWinnerService
    {
        private readonly IGame _game;

        public WinnerService(IGame game)
        {
            _game = game;
        }
        public void PrintWinner()
        {
            var winner = _game.Players.First(p => p.Position.Number == BoardSettings.MaxSpaces);
            
            _game.MessageEvents.OnOutputWithNewline("Winner".PadLeft((_game.Players.IndexOf(winner) + 1) * 20));
        }
    }
}
