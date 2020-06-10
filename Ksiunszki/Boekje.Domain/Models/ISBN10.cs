using Boekje.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Boekje.Domain.Models
{
    public class ISBN10 : ISBN
    {
        private Regex format = new Regex("^[\\dX-]+$");

        public ISBN10(string isbn) : base(isbn)
        {
        }

        public override void Validate(string value)
        {
            if( !format.IsMatch(value) )
                throw new Exception("The ISBN-10 contain invalid characters.");

            var digits = Regex.Replace(value, "-", "");

            if( digits.Length != 10 )
                throw new Exception("The ISBN-10 doesn't contain exactly ten digits");

            var digitList = digits
                .ToArray()
                .Select(x => x == 'X' ? 10 : int.Parse(x.ToString()));

            int lastDigit = digitList.Last();
            int controlSum = digitList.Sum() % 11;

            if(controlSum != lastDigit)
                throw new Exception("The ISBN-10 checksum failed.");
        }
    }
}
