using System;
using System.Collections.Generic;
using System.Text;
using Application.Common.Settings;

namespace Application.Models
{
    public class Board
    {
        public Board()
        {
            Spaces = new Space[BoardSettings.MaxSpaces];
        }
        public Space[] Spaces { get; set; }
    }
}
