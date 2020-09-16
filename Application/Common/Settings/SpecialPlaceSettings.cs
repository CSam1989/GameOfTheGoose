namespace Application.Common.Settings
{
    public static class SpecialPlaceSettings
    {
        public const int BridgeToGoSpace = 12;
        public const int MazeToGoSpace = 39;
        public const int DeathToGoSpace = 0;
        public const int InnSkipCount = 1;
        public const int PrisonSkipCount = 3;

        /// <summary>
        ///     SpecialThrow gives an array which contains an array with values (0: throw / 1: dice 1 / 2: dice 2 / 3:
        ///     position to go to)
        /// </summary>
        public static readonly int[][] SpecialGooseThrows =
        {
            //0: throw / 1: dice 1 / 2: dice 2 / 3: position to go to
            new[] {1, 5, 4, 26},
            new[] {1, 6, 3, 53}
        };
    }
}