using System;
using System.Collections.Generic;
using System.Text;
using Application.Common.Settings;

namespace Application.Models
{
    public class Player
    {
        public string Name { get; set; }
        public Space Position { get; set; }
        public int SkipCount { get; set; }
        public bool IsInWell { get; set; }

        public void MovePosition(int dice, Board board)
        {

        }
    }
}
