using System;
using System.Collections.Generic;
using System.Text;
using Application.Common.Interfaces;

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
        public virtual void Act(Player player, IGame game) { }
    }
}
