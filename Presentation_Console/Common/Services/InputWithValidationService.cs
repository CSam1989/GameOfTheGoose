using System;
using System.Collections.Generic;
using System.Text;
using Application.Common.Interfaces;
using Application.Common.Settings;

namespace Presentation_Console.Common.Services
{
    public class InputWithValidationService : IInputWithValidationService
    {
        private readonly IIOService _ioService;
        private readonly IValidationService _validation;

        public InputWithValidationService(
            IIOService ioService,
            IValidationService validation)
        {
            _ioService = ioService;
            _validation = validation;
        }
        public int InputPlayerCount()
        {
            string input;
            int playerCount;

            do
            {
                _ioService.OutputMessage($"How many players want to join this game? (min {PlayerAmount.Min} & max {PlayerAmount.Max}): ");
                input = _ioService.InputMessage();
            } while (!_validation.IsValidNumber(input, out playerCount) || !_validation.IsValidNumberOfPieces(playerCount));

            return playerCount;
        }
    }
}
