using System;
using System.Collections.Generic;
using System.Text;
using Application.Common.Interfaces.Handlers;
using Application.Common.Interfaces.services;
using Presentation_Console.Common.Services;

namespace Presentation_Console.Common.Handlers
{
    public class CustomGlobalExceptionHandler : IExceptionHandler
    {
        private readonly IIOService _io;

        public CustomGlobalExceptionHandler(IIOService io)
        {
            _io = io;
        }

        public void UnhandledExceptionTrapper(object sender, UnhandledExceptionEventArgs e)
        {
            _io.OutputWithNewLineMessage(e.ExceptionObject.ToString());
            _io.OutputWithNewLineMessage("Press Enter to Exit");
            _io.WaitForKey();
            Environment.Exit(0);
        }
    }
}
