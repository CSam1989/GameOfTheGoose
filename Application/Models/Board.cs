using Application.Common.Settings;

namespace Application.Models
{
    public class Board
    {
        public Board(AppConfig config)
        {
            Spaces = new Space[config.Settings.MaxSpaces + 1]; // max spaces + starting space(0)
        }

        public Space[] Spaces { get; set; }
    }
}