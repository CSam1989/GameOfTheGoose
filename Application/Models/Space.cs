using Application.Common.Interfaces.Strategies;

namespace Application.Models
{
    public class Space
    {
        public Space(int number, IAct spaceAction)
        {
            Number = number;
            SpaceAction = spaceAction;
        }

        public int Number { get; set; }

        public IAct SpaceAction { get; set; }
    }
}