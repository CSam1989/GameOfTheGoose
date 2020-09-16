using System;
using System.Collections.Generic;
using System.Text;
using Application.Common.Interfaces;
using Application.Common.Interfaces.services;
using Application.Common.Settings;

namespace Application.Common.Services
{
    public class ValidationService : IValidationService
    {
        public bool IsValidNumber(string input, out int output)
        {
            return int.TryParse(input, out output);
        }

        public bool IsValidNumberOfPieces(int numberOfPieces)
        {
            return numberOfPieces >= PlayerAmount.Min && numberOfPieces <= PlayerAmount.Max;
        }
    }
}
