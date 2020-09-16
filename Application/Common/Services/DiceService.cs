using System;
using Application.Common.Interfaces.services;
using Application.Common.Settings;

namespace Application.Common.Services
{
    public class DiceService : IDiceService
    {
        private readonly AppConfig _config;
        private readonly Random _random;

        public DiceService(AppConfig config)
        {
            _config = config;
            _random = new Random();
        }

        public int[] Roll()
        {
            var diceThrows = new int[_config.Settings.ThrowAmount];

            for (var i = 0; i < diceThrows.Length; i++)
                diceThrows[i] = _random.Next(_config.Settings.MinDice, _config.Settings.MaxDice + 1);
            //Next returns a value less then maxvalue => max dice throw = max value + 1
            return diceThrows;
        }
    }
}