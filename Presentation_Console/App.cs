using Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Models;
using IGame = Application.Common.Interfaces.IGame;

namespace Presentation_Console
{
    public class App
    {
        private readonly IGame _game;
        private readonly IGameController _gameController;
        private readonly IIOService _ioService;
        private readonly IInputWithValidationService _input;

        public App(
            IGame game,
            IGameController gameController,
            IIOService ioService,
            IInputWithValidationService input)
        {
            _game = game;
            _gameController = gameController;
            _ioService = ioService;
            _input = input;
        }

        // Equivalent to Main in Program.cs
        public void Run()
        {
            //Adding events to runtime
            _game.InputMessage += _ioService.InputMessage;
            _game.OutputMessage += _ioService.OutputMessage;
            _game.OutputNewLineMessage += _ioService.OutputWithNewLineMessage;
            _game.WaitForKey += _ioService.WaitForKey;

            var playerCount = _input.InputPlayerCount();

            _gameController.Run(playerCount);
            //Adds global exception handling
            //AppDomain.CurrentDomain.UnhandledException += _exceptionHandler.UnhandledExceptionTrapper;

        }
    }
}