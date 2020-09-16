using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Common.Settings
{
    public static class SpecialGooseSettings
    {
        public const int Throw = 1;

        /// <summary>SpecialThrow gives an array which contains an array with values (0: dice 1 / 1: dice 2 / 2: position to go to)</summary>
        public static readonly int[][] SpecialThrows =
        {
            new int[] {5, 4, 26},
            new int[] {6, 3, 53}
        };
    }
}
