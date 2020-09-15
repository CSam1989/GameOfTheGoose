using Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation_Console
{
    public class App
    {
        public App()
        {
        }

        // Equivalent to Main in Program.cs
        public void Run()
        {
            //Adds global exception handling
            //AppDomain.CurrentDomain.UnhandledException += _exceptionHandler.UnhandledExceptionTrapper;

        }
    }
}