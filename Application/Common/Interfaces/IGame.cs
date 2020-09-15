using System.Collections.Generic;
using Application.Common.Delegates;
using Application.Models;

namespace Application.Common.Interfaces
{
    public interface IGame
    {
        ICollection<Player> Players { get; set; }
        ICollection<Player> PlayersInWell { get; set; }
        Board Board { get; set; }
        int Turn { get; set; }
        bool HasWinner { get; set; }
    }
}