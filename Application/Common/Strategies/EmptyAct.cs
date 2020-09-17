using Application.Common.Interfaces.Strategies;
using Application.Models;

namespace Application.Common.Strategies
{
    public class EmptyAct : IAct
    {
        //Null object pattern => regular spaces
        public string Act(Player player)
        {
            return string.Empty;
        }
    }
}