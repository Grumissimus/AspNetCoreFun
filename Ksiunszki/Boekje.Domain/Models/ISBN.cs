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
        /*
        {
            var isbn = Regex.Replace(value, "-", "");
            bool validated;

            switch (isbn.Length)
            {
                case 10:
                    validated = ValidateIsbn10(isbn);
                    break;
                case 13:
                    validated = ValidateIsbn13(isbn);
                    break;
                default:
                    throw new ArgumentException("The ISBN has invalid format. The ISBN should have 10 or 13 digits.");
            }

            if (!validated)
            {
                throw new ArgumentException("The ISBN is invalid.");
            }
        }*/

        private bool ValidateIsbn10(string isbn)
        {
        }

        private bool ValidateIsbn13(string isbn)
        {
            if( isbn.Contains('X') )
                throw new ArgumentException("The ISBN-13 cannot contain \'X\'.");

            var sum = isbn
                .ToArray()
                .Select(x => int.Parse(x.ToString()));

            var checkSum = sum.Where(x => x % 2 != 0).Sum() + sum.Where(x => x % 2 == 0).Select(x => x * 3).Sum();

            return checkSum % 10 == 0;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}