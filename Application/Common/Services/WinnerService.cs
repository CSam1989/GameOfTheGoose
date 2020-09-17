using System.Linq;
using Application.Common.Interfaces.Models;
using Application.Common.Interfaces.Services;
using Application.Common.Settings;

namespace Application.Common.Services
{
    public class WinnerService : IWinnerService
    {
        private readonly AppConfig _config;
        private readonly IGame _game;

        public WinnerService(IGame game, AppConfig config)
        {
            _game = game;
            _config = config;
        }

        public void PrintWinner()
        {
            var winner = _game.Players.First(p => p.Position.Number == _config.Settings.MaxSpaces);

            //Hier maak ik geen gebruik van de aligned output omdat ik hier moet alignen op een bepaalde column en niet moet verderbouwen op vorige output
            _game.MessageEvents.OnOutputWithNewline(
                "Winner".PadLeft((_game.Players.IndexOf(winner) + 1) * _config.Settings.OutputAlign));
        }
    }
}