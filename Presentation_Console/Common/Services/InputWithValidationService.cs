using Application.Common.Interfaces.services;
using Application.Common.Settings;

namespace Presentation_Console.Common.Services
{
    public class InputWithValidationService : IInputWithValidationService
    {
        private readonly AppConfig _config;
        private readonly IIOService _ioService;
        private readonly IValidationService _validation;

        public InputWithValidationService(
            IIOService ioService,
            IValidationService validation,
            AppConfig config)
        {
            _ioService = ioService;
            _validation = validation;
            _config = config;
        }

        public int InputPlayerCount()
        {
            string input;
            int playerCount;

            do
            {
                _ioService.OutputMessage(
                    $"How many players want to join this game? (min {_config.Settings.MinPlayers} & max {_config.Settings.MaxPlayers}): ");
                input = _ioService.InputMessage();
            } while (!_validation.IsValidNumber(input, out playerCount) ||
                     !_validation.IsValidNumberOfPieces(playerCount));

            return playerCount;
        }
    }
}