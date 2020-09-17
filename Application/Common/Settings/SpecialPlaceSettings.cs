namespace Application.Common.Settings
{
    public class SpecialPlaceSettings
    {
        public int BridgeToGoSpace { get; set; }
        public int MazeToGoSpace { get; set; }
        public int DeathToGoSpace { get; set; }
        public int InnSkipCount { get; set; }
        public int PrisonSkipCount { get; set; }

        public SpecialGooseThrows[] SpecialGooseThrows { get; set; }
    }
}