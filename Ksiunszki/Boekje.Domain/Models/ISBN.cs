using Boekje.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Boekje.Domain.Models
{
    public abstract class ISBN : ValueObject
    {
        public string Value { get; private set; }

        public ISBN(string isbn)
        {
            Validate(isbn);
            Value = isbn;
        }

        public abstract void Validate(string value);

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}