namespace Application.Common.Interfaces.services
{
    public interface IIOService
    {
        void OutputWithNewLineMessage(string message);
        void OutputMessageAligned(string message);
        void OutputMessage(string message);
        string InputMessage();
        void WaitForKey();
    }
}