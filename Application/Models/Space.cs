using Application.Common.Interfaces.Strategies;

namespace Application.Models
{
    public class Space
    {
        public Space(int number)
        {
            Number = number;
        }

        public int Number { get; set; }

        public IAct SpaceAction { get; set; }
    }
}