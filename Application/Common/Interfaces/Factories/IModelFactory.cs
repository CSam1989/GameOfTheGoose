using Application.Models;

namespace Application.Common.Interfaces.Factories
{
    public interface IModelFactory
    {
        Board CreateBoard();
        Space CreateSpace(int spaceNumber);
        Player CreatePlayer(string name);
    }
}