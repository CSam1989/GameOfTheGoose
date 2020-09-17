using Application.Common.Interfaces.Strategies;

namespace Application.Common.Interfaces.Factories
{
    public interface ISpaceActionFactory
    {
        IAct CreateSpaceAction(int spaceNumber);
    }
}