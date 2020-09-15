using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Application.Common.Interfaces;
using Application.Models;

namespace Application.GameController
{
    public class Director : IGameController
    {
        private readonly IIOService _io;
        private readonly IModelFactory _modelFactory;
        private readonly IGameBuilder _builder;
        public IGame Game { get; }

        public Director(
            IGame game,
            IIOService io,
            IModelFactory modelFactory,
            IGameBuilder builder)
        {
            _io = io;
            _modelFactory = modelFactory;
            _builder = builder;
            Game = game;
        }

        public void Run(int playerCount)
        {
            Game.Board = _modelFactory.CreateBoard();

            _builder.BuildBoard(Game.Board);

            Game.Players = _builder.AddPlayers(playerCount);

            _io.OutputWithNewLineMessage(Game.Players.Aggregate(
                                             "",
                                             (current, piece) => current + $"{piece.Name}".PadLeft(20))
                                         + Environment.NewLine);

            while (!Game.HasWinner)
            {
                Game.Turn++;
                _io.OutputMessage($"[PRESS ENTER TO PLAY TURN {Game.Turn}]");
                _io.WaitForKey();
                _io.OutputWithNewLineMessage($"Turn {Game.Turn} {Environment.NewLine}");

            }
        }
    }
}
