using System;
using System.Collections.Generic;
using System.Text;

namespace Tasdk.Exceptions
{
    class NegativeException:Exception
    {
        public NegativeException(string message) : base(message)
        {
        }

    }
}
