﻿using System;
using System.Collections.Generic;
using System.Text;
using Application.Common.Interfaces;
using Application.Common.Settings;
using Application.Models;

namespace Application.SpecialSpaces
{
    public class Maze: Space
    {
        public Maze(int number) : base(number)
        {
        }

        public override void Act(Player player, IGame game)
        {
            player.Position = game.Board.Spaces[SpecialPlaceSettings.MazeToGoSpace];

            // TODO: Change the Console write to ioService 
            Console.Write($" -> S{player.Position.Number}");
        }
    }
}
