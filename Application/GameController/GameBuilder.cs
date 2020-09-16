using System.Collections.Generic;
using Application.Common.Interfaces.Factories;
using Application.Common.Interfaces.GameController;
using Application.Models;

namespace Application.GameController
{
    public class GameBuilder : IGameBuilder
    {
        private readonly IModelFactory _modelFactory;

        public GameBuilder(
            IModelFactory modelFactory)
        {
            _modelFactory = modelFactory;
        }

        public void BuildBoard(Board board)
        {
            for (var i = 0; i < board.Spaces.Length; i++) board.Spaces[i] = _modelFactory.CreateSpace(i);
        }

        public IList<Player> AddPlayers(int count)
        {
            var pieces = new List<Player>();

            for (var i = 1; i <= count; i++) pieces.Add(_modelFactory.CreatePlayer($"PIECE {i}"));
            return pieces;
        }
    }
}