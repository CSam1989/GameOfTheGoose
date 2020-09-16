using System.Linq;
using Application.Common.Interfaces.Models;
using Application.Common.Interfaces.Services;
using Application.Common.Settings;

namespace Application.Common.Services
{
    public class WinnerService : IWinnerService
    {
        private readonly IGame _game;
        private readonly AppConfig _config;

        public WinnerService(IGame game, AppConfig config)
        {
            _game = game;
            _config = config;
        }

        public void PrintWinner()
        {
            var winner = _game.Players.First(p => p.Position.Number == _config.Settings.MaxSpaces);

            _game.MessageEvents.OnOutputWithNewline("Winner".PadLeft((_game.Players.IndexOf(winner) + 1) * _config.Settings.OutputAlign));
        }
    }
}