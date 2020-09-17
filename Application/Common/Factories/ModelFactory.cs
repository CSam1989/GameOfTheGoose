using Application.Common.Interfaces.Factories;
using Application.Common.Settings;
using Application.Models;

namespace Application.Common.Factories
{
    public class ModelFactory : IModelFactory
    {
        private readonly AppConfig _config;
        private readonly ISpaceActionFactory _spaceActionFactory;

        public ModelFactory(AppConfig config, ISpaceActionFactory spaceActionFactory)
        {
            _config = config;
            _spaceActionFactory = spaceActionFactory;
        }

        public Board CreateBoard()
        {
            return new Board(_config.Settings.MaxSpaces);
        }

        public Space CreateSpace(int spaceNumber)
        {
            return new Space(spaceNumber) {SpaceAction = _spaceActionFactory.CreateSpaceAction(spaceNumber)};
        }

        public Player CreatePlayer(string name)
        {
            return new Player
            {
                Name = name,
                Position = CreateSpace(0)
            };
        }
    }
}