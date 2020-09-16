using Application.Common.DelegatesEvents;

namespace Application.Common.Interfaces.DelegatesEvents
{
    public interface IMessageEvents
    {
        event OutputDelegate OutputWithNewline;
        event OutputDelegate OutputAligned;
        event OutputDelegate Output;
        event WaitDelegate Wait;
        void OnOutputWithNewline(string message);
        void OnOutputAligned(string message);
        void OnOutput(string message);
        void OnWait();
    }
}