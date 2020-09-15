﻿using System;
using System.Collections.Generic;
using System.Text;
using Application.Common.Delegates;
using Application.Common.Interfaces;

namespace Application.Models
{
    public class Game : IGame
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
