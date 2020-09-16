using System;
using System.Linq;
using Application.Common.Interfaces.Factories;
using Application.Common.Settings;
using Application.Models;
using Application.SpecialSpaces;

namespace Application.Common.Factories
{
    public class ModelFactory : IModelFactory
    {
        private readonly AppConfig _config;

        public ModelFactory(AppConfig config)
        {
            _config = config;
        }

        public Board CreateBoard()
        {
            return new Board(_config);
        }

        public Space CreateSpace(int spaceNumber)
        {
            foreach (var specialSpace in _config.SpecialSpaces)
                if (specialSpace.Space == spaceNumber)
                    return (Space) Activator.CreateInstance(
                        Type.GetType($"Application.SpecialSpaces.{specialSpace.Name}"), new object[] {spaceNumber, _config});

            return _config.GooseSpaces.Any(goosePlace => goosePlace == spaceNumber)
                ? new Goose(spaceNumber, _config)
                : new Space(spaceNumber);
        }

        public Player CreatePlayer(string name)
        {
            return new Player(_config)
            {
                Name = name,
                Position = CreateSpace(0)
            };
        }
    }
}