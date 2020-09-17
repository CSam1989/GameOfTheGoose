using System;

namespace Application.Common.Interfaces.Handlers
{
    public interface IExceptionHandler
    {
        void UnhandledExceptionTrapper(object sender, UnhandledExceptionEventArgs e);
    }
}