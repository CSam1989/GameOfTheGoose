using Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Models;

namespace Presentation_Console
{
    public class App
    {
        private readonly IIOService _ioService;

        public App(IIOService ioService)
        {
            _ioService = ioService;
        }

        // Equivalent to Main in Program.cs
        public void Run()
        {
            var game = new Game();
            //Adding events to runtime
            game.InputMessage += _ioService.InputMessage;
            game.OutputMessage += _ioService.OutputMessage;
            game.OutputNewLineMessage += _ioService.OutputWithNewLineMessage;
            game.WaitForKey += _ioService.WaitForKey;

            //Adds global exception handling
            //AppDomain.CurrentDomain.UnhandledException += _exceptionHandler.UnhandledExceptionTrapper;

        }
    }
}