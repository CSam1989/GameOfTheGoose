using System;
using Application.Common.Interfaces;
using Application.Common.Settings;

namespace Application.Common.Services
{
    public class DiceService : IDiceService
    {
        private readonly Random _random;
        public DiceService()
        {
            _random = new Random();
        }

        public int[] Roll()
        {
            var diceThrows = new int[DiceSettings.ThrowAmount];

            for (int i = 0; i < diceThrows.Length; i++)
            {
                diceThrows[i] = _random.Next(DiceSettings.Min, DiceSettings.Max + 1);
            }
            //Next returs a value less then maxvalue => max dice throw = max value + 1
            return diceThrows;
        }
    }
}