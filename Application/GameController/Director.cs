using System;
using System.Collections.Generic;
using System.Text;
using Application.Common.Interfaces;
using Application.Models;

namespace Application.GameController
{
    public class Director : IGameController
    {
        private readonly IModelFactory _modelFactory;
        private readonly IGameBuilder _builder;
        public IGame Game { get; }

        public Director(
            IGame game,
            IModelFactory modelFactory,
            IGameBuilder builder)
        {
            _modelFactory = modelFactory;
            _builder = builder;
            Game = game;
        }

        public void Run(int playerCount)
        {
            Game.Board = _modelFactory.CreateBoard();

            _builder.BuildBoard(Game.Board);

        }
    }
}
