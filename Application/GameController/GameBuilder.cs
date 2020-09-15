using System;
using System.Collections.Generic;
using System.Text;
using Application.Common.Interfaces;
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
            for (int i = 0; i < board.Spaces.Length; i++)
            {
                board.Spaces[i] = _modelFactory.CreateSpace(i + 1);
            }
        }
    }
}
