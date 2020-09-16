using Application.Common.Interfaces.Models;

namespace Application.Common.Interfaces.GameController
{
    public interface IGameController
    {
        IGame Game { get; }
        void Run(int playerCount);
    }
}