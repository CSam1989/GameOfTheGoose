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
        private readonly IGameController _gameController;
        private readonly IIOService _io;
        private readonly IInputWithValidationService _input;

        public App(
            IGame game,
            IGameController gameController,
            IIOService io,
            IInputWithValidationService input)
        {
            _gameController = gameController;
            _io = io;
            _input = input;
        }

        // Equivalent to Main in Program.cs
        public void Run()
        {
            _io.OutputWithNewLineMessage($"Welcome to a game of goose! {Environment.NewLine}");

            var playerCount = _input.InputPlayerCount();

            _gameController.Run(playerCount);
            //Adds global exception handling
            //AppDomain.CurrentDomain.UnhandledException += _exceptionHandler.UnhandledExceptionTrapper;

        }
    }
}