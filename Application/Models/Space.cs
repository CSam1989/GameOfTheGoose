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
        public virtual string Act(Player player, IGame game)
        {
            return string.Empty;
        }
    }
}