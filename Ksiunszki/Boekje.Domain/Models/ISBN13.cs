using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Boekje.Domain.Models
{
    public class ISBN13 : ISBN
    {
        private Regex format = new Regex("^[\\d-]+$");

        public ISBN13(string isbn) : base(isbn)
        {
        }

        public override void Validate(string value)
        {
            if (value.Contains('X'))
                throw new ArgumentException("The ISBN-13 contains \'X\'. Did you confuse with ISBN-10 format?");

            if (!format.IsMatch(value))
                throw new ArgumentException("The ISBN-13 contains invalid characters.");

            var digits = Regex.Replace(value, "-", "");

            if (digits.Length != 13)
                throw new Exception("The ISBN-13 doesn't contain exactly thirteen digits");

            var sum = digits
                .ToArray()
                .Select(x => int.Parse(x.ToString()));

            var checkSum = sum.Where(x => x % 2 != 0).Sum() + sum.Where(x => x % 2 == 0).Select(x => x * 3).Sum();

            if (checkSum % 10 == 0)
                throw new Exception("The ISBN-13 checksum failed.");
        }
    }
}
