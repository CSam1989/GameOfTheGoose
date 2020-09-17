using System;
using Application.Common.Interfaces.services;
using Application.Common.Settings;

namespace Presentation_Console.Common.Services
{
    public class IOService : IIOService
    {
        private readonly AppConfig _config;

        public IOService(AppConfig config)
        {
            _config = config;
        }

        public void OutputWithNewLineMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void OutputMessageAligned(string message)
        {
            Console.Write(message.PadLeft(_config.Settings.OutputAlign));
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