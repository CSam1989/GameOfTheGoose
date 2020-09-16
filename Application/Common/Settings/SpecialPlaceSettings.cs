namespace Application.Common.Settings
{
    public class SpecialPlaceSettings
    {
        public int BridgeToGoSpace { get; set; }
        public int MazeToGoSpace { get; set; }
        public int DeathToGoSpace { get; set; }
        public int InnSkipCount { get; set; }
        public int PrisonSkipCount { get; set; }

        /// <summary>
        ///     SpecialThrow gives an array which contains an array with values (0: throw / 1: dice 1 / 2: dice 2 / 3:
        ///     position to go to)
        /// </summary>
        public int[][] SpecialGooseThrows { get; set; }
    }
}