using Application.Models;

namespace Application.Common.Interfaces
{
    public interface IGameController
    {
        IGame Game { get; }
        void Run(int playerCount);
    }
}