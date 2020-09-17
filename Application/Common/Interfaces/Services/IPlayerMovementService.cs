using Application.Models;

namespace Application.Common.Interfaces.Services
{
    public interface IPlayerMovementService
    {
        void MovePosition(Player player, Board board);
    }
}