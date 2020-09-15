using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Models
{
    public class Game
    {
        public ICollection<Player> Players { get; set; }
        public ICollection<Player> PlayersInWell { get; set; }
        public Board Board { get; set; }
        public int Turn { get; set; }
    }
}
