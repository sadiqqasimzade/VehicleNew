using System;
using System.Collections.Generic;
using System.Text;

namespace Tasdk.Exceptions
{
    class ZeroOrNegativeException : Exception
    {
        public ZeroOrNegativeException(string message) : base(message)
        {

        }
    }
}
