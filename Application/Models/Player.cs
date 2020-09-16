using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Application.Common.Settings;

namespace Application.Models
{
    public class Player
    {
        public Player()
        {
            CurrentDiceThrow = new[] {0, 0}; //start of game, player hasn't thrown yet
        }
        public string Name { get; set; }
        public int[] CurrentDiceThrow { get; set; }
        public Space Position { get; set; }
        public int SkipCount { get; set; }
        public bool IsInWell { get; set; }

        public void MovePosition(Board board)
        {
            var indexNewPosition = Position.Number + CurrentDiceThrow.Sum();

            //Extra logic for when piece is above the end space
            if (indexNewPosition >= BoardSettings.MaxSpaces)
                indexNewPosition -= (indexNewPosition - BoardSettings.MaxSpaces) * 2;

            Position = board.Spaces[indexNewPosition];
        }
    }
}
