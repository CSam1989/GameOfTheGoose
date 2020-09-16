using System.Collections.Generic;
using Application.Common.Interfaces.DelegatesEvents;
using Application.Models;

namespace Application.Common.Interfaces.Models
{
    public interface IGame
    {
        IList<Player> Players { get; set; }
        IList<Player> PlayersInWell { get; set; }
        Board Board { get; set; }
        int Turn { get; set; }
        bool HasWinner { get; set; }
        IMessageEvents MessageEvents { get; set; }
    }
}