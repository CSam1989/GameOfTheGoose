using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Common.Settings
{
    public static class SpecialPlaceSettings
    {
        /// <summary>SpecialThrow gives an array which contains an array with values (0: throw / 1: dice 1 / 2: dice 2 / 3: position to go to)</summary>
        public static readonly int[][] SpecialGooseThrows =
        {
            new int[] { 1, 5, 4, 26 },
            new int[] { 1, 6, 3, 53 }
        };
    }
}
