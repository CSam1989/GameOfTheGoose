using System;
using System.Collections.Generic;
using System.Text;
using Application.Common.Interfaces;

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
