﻿using System;
using System.Collections.Generic;
using System.Text;
using Application.Common.Interfaces;
using Application.Common.Interfaces.Models;
using Application.Common.Settings;
using Application.Models;

namespace Application.SpecialSpaces
{
    public class Inn: Space
    {
        public Inn(int number) : base(number)
        {
        }

        public override void Act(Player player, IGame game)
        {
            player.SkipCount = SpecialPlaceSettings.InnSkipCount;

            game.MessageEvents.OnOutput($"-> Skip {SpecialPlaceSettings.InnSkipCount}");
        }
    }
}
