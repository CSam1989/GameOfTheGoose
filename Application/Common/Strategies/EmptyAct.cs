using System;
using System.Collections.Generic;
using System.Text;
using Application.Common.Interfaces.Strategies;
using Application.Models;

namespace Application.Common.Strategies
{
    public class EmptyAct: IAct
    {
        //Null object pattern => regular spaces
        public string Act(Player player)
        {
            return String.Empty;
        }
    }
}
