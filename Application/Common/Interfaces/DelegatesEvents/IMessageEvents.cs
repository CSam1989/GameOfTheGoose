using Application.Common.DelegatesEvents;

namespace Application.Common.Interfaces.DelegatesEvents
{
    public interface IMessageEvents
    {
        event OutputWithNewlineDelegate OutputWithNewline;
        event OutputDelegate Output;
        event WaitDelegate Wait;
        void OnOutputWithNewline(string message);
        void OnOutput(string message);
        void OnWait();
    }
}