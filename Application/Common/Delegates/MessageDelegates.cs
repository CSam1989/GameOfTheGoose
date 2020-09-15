using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Common.Delegates
{
    public delegate void OutputWithNewlineDelegate(string message);
    public delegate void OutputDelegate(string message);
    public delegate string InputDelegate();
    public delegate void WaitDelegate();
}
