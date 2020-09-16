using System;
using System.Collections.Generic;
using System.Text;
using Application.Common.DelegatesEvents;
using Application.Common.Interfaces;

namespace Application.Models
{
    public class Game : IGame
    {
        public Game(IMessageEvents messageEvents)
        {
            MessageEvents = messageEvents;
            Players = new List<Player>();
            PlayersInWell = new List<Player>();
        }

        public IList<Player> Players { get; set; }
        public IList<Player> PlayersInWell { get; set; }
        public Board Board { get; set; }
        public int Turn { get; set; }
        public bool HasWinner { get; set; }

        public IMessageEvents MessageEvents { get; set; }
    }
}
