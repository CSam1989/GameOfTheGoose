using System;
using Application.Common.Interfaces.services;

namespace Presentation_Console.Common.Services
{
    public class IOService : IIOService
    {
        public void OutputWithNewLineMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void OutputMessage(string message)
        {
            Console.Write(message);
        }

        public string InputMessage()
        {
            return Console.ReadLine();
        }

        public void WaitForKey()
        {
            Console.ReadKey();
        }
    }
}