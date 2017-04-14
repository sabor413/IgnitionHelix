using System;

namespace DI_MVC5.Core
{
    public class AnyLogger : ILogger
    {
        public string Info(string entry)
        {
            return entry;
        }
    }
}