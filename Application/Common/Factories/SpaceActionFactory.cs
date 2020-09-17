using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Application.Common.Interfaces.Factories;
using Application.Common.Interfaces.Models;
using Application.Common.Interfaces.Services;
using Application.Common.Interfaces.Strategies;
using Application.Common.Settings;
using Application.Common.Strategies;

namespace Application.Common.Factories
{
    public class SpaceActionFactory : ISpaceActionFactory
    {
        private readonly AppConfig _config;
        private readonly IGame _game;
        private readonly IPlayerMovementService _playerMovement;

        public SpaceActionFactory(AppConfig config, IGame game, IPlayerMovementService playerMovement)
        {
            _config = config;
            _game = game;
            _playerMovement = playerMovement;
        }

        public IAct CreateSpaceAction(int spaceNumber)
        {
            try
            {
                var space = _config.SpecialSpaces.FirstOrDefault(s => s.Space == spaceNumber);
                return (IAct)Activator.CreateInstance(
                    Type.GetType($"Application.Common.Strategies.{space.Name}Act"),
                    new object[] { _config, _game });
            }
            catch
            {
                //If not a special place => check if its a goose special place
                if(_config.GooseSpaces.Contains(spaceNumber))
                    return new GooseAct(_config, _game, _playerMovement);
                //Else return an empty Act (regular spaces)
                return new EmptyAct();
            }
        }
    }
}
