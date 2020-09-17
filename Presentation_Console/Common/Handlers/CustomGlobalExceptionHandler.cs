using System;
using Application.Common.Interfaces.Handlers;
using Application.Common.Interfaces.services;

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