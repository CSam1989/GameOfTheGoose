using System.Linq;
using Application.Common.Interfaces.Services;
using Application.Common.Settings;
using Application.Models;

namespace Application.Common.Services
{
    public class PlayerMovementService : IPlayerMovementService
    {
        private readonly AppConfig _config;

        public PlayerMovementService(AppConfig config)
        {
            _config = config;
        }

        public void MovePosition(Player player, Board board)
        {
            var indexNewPosition = player.Position.Number + player.CurrentDiceThrow.Sum();

            //Extra logic for when piece is above the end space
            if (indexNewPosition >= _config.Settings.MaxSpaces)
                indexNewPosition -= (indexNewPosition - _config.Settings.MaxSpaces) * 2;

            player.Position = board.Spaces[indexNewPosition];
        }
    }
}
