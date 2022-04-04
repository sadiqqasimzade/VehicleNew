using System;
using System.Collections.Generic;
using System.Text;

namespace Tasdk.Exceptions
{
    internal class NoSpeaceAvailableException:Exception
    {
        public NoSpeaceAvailableException(string message = "No space available") :base(message)
        {

        }
    }
}
