using System.Collections.Generic;
using Application.Common.Extensions;
using Application.Common.Interfaces.Models;
using Application.Common.Interfaces.services;
using Application.Common.Strategies;
using Application.Models;

namespace Application.Common.Services
{
    public class GameService : IGameService
    {
        private readonly IDiceService _dice;
        private readonly IGame _game;

        public GameService(IDiceService dice, IGame game)
        {
            _dice = dice;
            _game = game;
        }


        // Hier ben ik niet 100% of dit wel SRP is?? omdat ik hier de players verzet + output doorgeef
        // Ik heb hier toch voor gekozen omdat ik dan mijn onoutputalign event kan gebruiken die ergens 1x gedefinieerd is
        // Mocht ik dan de alignment willen veranderen, dan hoef ik dit maar op 1 plek te doen ipv hier een padleft op verschillende plekken
        // DRY > SRP ???
        public void MovePieces(ICollection<Player> players)
        {
            foreach (var player in players)
            {
                if (player.SkipCount > 0)
                {
                    _game.MessageEvents.OnOutputAligned($"skip {player.SkipCount} turn(s)");
                    player.SkipCount--;
                    continue;
                }

                if (player.IsInWell)
                {
                    _game.MessageEvents.OnOutputAligned($"In Well");
                    continue;
                }

                player.CurrentDiceThrow = _dice.Roll();
                player.MovePosition(_game.Board);

                var outputToReturn = $"{player.CurrentDiceThrow.DiceThrowsToString()}: S{player.Position.Number}";

                outputToReturn += player.Position.SpaceAction.Act(player);

                _game.MessageEvents.OnOutputAligned(outputToReturn);
            }

            _game.MessageEvents.OnOutputWithNewline(string.Empty);
        }
    }
}