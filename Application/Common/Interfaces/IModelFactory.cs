using Application.Models;

namespace Application.Common.Interfaces
{
    public interface IModelFactory
    {
        Models.Game CreateGame();
        Board CreateBoard();
        Space CreateSpace(int spaceNumber);
        Player CreatePlayer(string name);
    }
}