using System;
using System.Collections.Generic;
using System.Text;

namespace Boekje.Domain.Exceptions
{
    public class ISBNFailedChecksumException : ArgumentException
    {
        public ISBNFailedChecksumException() {}
        public ISBNFailedChecksumException(string message) : base(message) {}
        public ISBNFailedChecksumException(string message, Exception inner) : base(message, inner) {}
    }
}
