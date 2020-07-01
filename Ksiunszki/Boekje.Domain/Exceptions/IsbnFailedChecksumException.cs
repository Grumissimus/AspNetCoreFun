using System;
using System.Collections.Generic;
using System.Text;

namespace Boekje.Domain.Exceptions
{
    public class IsbnFailedChecksumException : ArgumentException
    {
        public IsbnFailedChecksumException() {}
        public IsbnFailedChecksumException(string message) : base(message) {}
        public IsbnFailedChecksumException(string message, Exception inner) : base(message, inner) {}
    }
}
