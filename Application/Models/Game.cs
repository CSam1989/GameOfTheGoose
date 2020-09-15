using System;
using System.Collections.Generic;
using System.Text;
using Application.Common.Delegates;

namespace Application.Models
{
    public class Game
    {
        public ICollection<Player> Players { get; set; }
        public ICollection<Player> PlayersInWell { get; set; }
        public Board Board { get; set; }
        public int Turn { get; set; }

        public event OutputDelegate OutputMessage;
        public event OutputWithNewlineDelegate OutputNewLineMessage;
        public event InputDelegate InputMessage;
        public event WaitDelegate WaitForKey;
    }
}
