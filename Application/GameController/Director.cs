using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Application.Common.Interfaces;
using Application.Common.Interfaces.Factories;
using Application.Common.Interfaces.GameController;
using Application.Common.Interfaces.Models;
using Application.Common.Interfaces.services;
using Application.Common.Interfaces.Services;
using Application.Common.Services;
using Application.Models;

namespace Application.GameController
{
    public class Director : IGameController
    {
        private readonly IModelFactory _modelFactory;
        private readonly IGameBuilder _builder;
        private readonly IGameService _gameService;
        private readonly IWinnerService _winnerService;
        public IGame Game { get; }

        public Director(
            IGame game,
            IModelFactory modelFactory,
            IGameBuilder builder,
            IGameService gameService,
            IWinnerService winnerService)
        {
            _modelFactory = modelFactory;
            _builder = builder;
            _gameService = gameService;
            _winnerService = winnerService;
            Game = game;
        }

        public void Run(int playerCount)
        {
            Game.Board = _modelFactory.CreateBoard();

            _builder.BuildBoard(Game.Board);

            Game.Players = _builder.AddPlayers(playerCount);

            Game.MessageEvents.OnOutputWithNewline(Game.Players.Aggregate(
                                             "",
                                             (current, piece) => current + $"{piece.Name}".PadLeft(20))
                                         + Environment.NewLine);

            while (!Game.HasWinner)
            {
                Game.Turn++;
                Game.MessageEvents.OnOutputWithNewline($"[PRESS ENTER TO PLAY TURN {Game.Turn}]");
                Game.MessageEvents.OnWait();
                Game.MessageEvents.OnOutputWithNewline($"Turn {Game.Turn} {Environment.NewLine}");

                _gameService.MovePieces(Game.Players);
            }

            _winnerService.PrintWinner();
            Game.MessageEvents.OnOutput("[PRESS ENTER TO FINISH GAME]");
            Game.MessageEvents.OnWait();
        }
    }
}
