using System;
using System.Collections.Generic;
using System.Text;
using Application.Common.Interfaces;
using Application.Models;

namespace Application.SpecialSpaces
{
    public class Bridge: Space
    {
        public Bridge(int number) : base(number)
        {
        }

        public override void Act(Player player, IGame game)
        {
            base.Act(player, game);
        }
    }
}
