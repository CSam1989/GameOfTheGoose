using System.Collections.Generic;
using Application.Models;

namespace Application.Common.Interfaces
{
    public interface IGameService
    {
        void MovePieces(ICollection<Player> players, Board board);
        void ActOnNewPosition(ICollection<Player> players);
    }
}