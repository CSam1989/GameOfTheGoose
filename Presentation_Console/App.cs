using Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Common.Interfaces.GameController;
using Application.Common.Interfaces.services;
using Application.Models;
using IGame = Application.Common.Interfaces.Models.IGame;

namespace Presentation_Console
{
    public class App
    {
        private readonly IGame _game;
        private readonly IGameController _gameController;
        private readonly IIOService _io;
        private readonly IInputWithValidationService _input;

        public App(
            IGame game,
            IGameController gameController,
            IIOService io,
            IInputWithValidationService input)
        {
            _game = game;
            _gameController = gameController;
            _io = io;
            _input = input;
        }

        // Equivalent to Main in Program.cs
        public void Run()
        {
            //Adds global exception handling
            //AppDomain.CurrentDomain.UnhandledException += _exceptionHandler.UnhandledExceptionTrapper;

            //assign handlers to events
            _game.MessageEvents.OutputWithNewline += _io.OutputWithNewLineMessage;
            _game.MessageEvents.Output += _io.OutputMessage;
            _game.MessageEvents.Wait += _io.WaitForKey;

            _game.MessageEvents.OnOutputWithNewline($"Welcome to a game of goose! {Environment.NewLine}");

            var playerCount = _input.InputPlayerCount();

            _gameController.Run(playerCount);
        }
    }
}