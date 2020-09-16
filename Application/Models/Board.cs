using Application.Common.Settings;

namespace Application.Models
{
    public class Board
    {
        public Board()
        {
            Spaces = new Space[BoardSettings.MaxSpaces + 1]; // max spaces + starting space (=0)
        }

        public Space[] Spaces { get; set; }
    }
}