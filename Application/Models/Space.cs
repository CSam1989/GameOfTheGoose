using Application.Common.Interfaces.Models;

namespace Application.Models
{
    public class Space
    {
        public Space(int number)
        {
            Number = number;
        }

        public int Number { get; set; }

        //Does nothing = Null Object Pattern
        public virtual void Act(Player player, IGame game)
        {
        }
    }
}