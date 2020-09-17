using Application.Common.Settings;

namespace Application.Models
{
    public class Board
    {
        public Board(int maxSpaces)
        {
            //initiating the ARRAY of spaces (not the actual space) => No need for modelFactory
            Spaces = new Space[maxSpaces + 1]; // max spaces + starting space(0)
        }

        public Space[] Spaces { get; set; }
    }
}