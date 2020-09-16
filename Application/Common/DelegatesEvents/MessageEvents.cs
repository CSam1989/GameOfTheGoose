using Application.Common.Interfaces.DelegatesEvents;

namespace Application.Common.DelegatesEvents
{
    public class MessageEvents : IMessageEvents
    {
        public event OutputDelegate OutputWithNewline;
        public event OutputDelegate OutputAligned;
        public event OutputDelegate Output;
        public event WaitDelegate Wait;

        public virtual void OnOutputWithNewline(string message)
        {
            OutputWithNewline?.Invoke(message);
        }

        public virtual void OnOutputAligned(string message)
        {
            OutputAligned?.Invoke(message);
        }

        public virtual void OnOutput(string message)
        {
            Output?.Invoke(message);
        }

        public virtual void OnWait()
        {
            Wait?.Invoke();
        }
    }
}