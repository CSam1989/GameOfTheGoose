using System.Collections.Generic;
using Application.Models;

namespace Application.Common.Interfaces
{
    public interface IGameBuilder
    {
        void BuildBoard(Board board);
        IList<Player> AddPlayers(int count);
    }
}