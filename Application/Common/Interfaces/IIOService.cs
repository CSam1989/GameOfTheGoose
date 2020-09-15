namespace Application.Common.Interfaces
{
    public interface IIOService
    {
        void OutputWithNewLineMessage(string message);
        void OutputMessage(string message);
        string InputMessage();
        void WaitForKey();
    }
}