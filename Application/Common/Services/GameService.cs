using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Application.Common.Interfaces;
using Application.Common.Settings;
using Application.Models;

namespace Application.Common.Services
{
    public class GameService : IGameService
    {
        private readonly IDiceService _dice;

        public GameService(IDiceService dice)
        {
            _dice = dice;
        }

        public void MovePieces(ICollection<Player> players, Board board)
        {

            foreach (var player in players)
            {
                player.MovePosition(_dice.Roll(), board);
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        public void ActOnNewPosition(ICollection<Player> players)
        {
            foreach (var player in players)
            {
                player.Position.Act(player);
            }
        }
    }
}
