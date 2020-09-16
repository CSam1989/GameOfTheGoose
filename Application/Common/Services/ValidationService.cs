using Application.Common.Interfaces.services;
using Application.Common.Settings;

namespace Application.Common.Services
{
    public class ValidationService : IValidationService
    {
        private readonly AppConfig _config;

        public ValidationService(AppConfig config)
        {
            _config = config;
        }

        public bool IsValidNumber(string input, out int output)
        {
            return int.TryParse(input, out output);
        }

        public bool IsValidNumberOfPieces(int numberOfPieces)
        {
            return numberOfPieces >= _config.Settings.MinPlayers && numberOfPieces <= _config.Settings.MaxPlayers;
        }
    }
}