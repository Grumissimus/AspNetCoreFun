using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Boekje.Domain.Models
{
    public static class ISBNMapper
    {
        public static ISBN13 From(ISBN10 isbn)
        {
            string newIsbn = "978-" + isbn;

            var clearIsbn = Regex.Replace(newIsbn, "-", "");

            var digits = clearIsbn
                .Select(x => x == 'X' ? 0 : int.Parse(x.ToString()))
                .ToArray();

            int checksum = 0;
            for (int i = 0; i < 12; i++)
            {
                checksum += (i + 1) % 2 != 0 ? digits[i] : digits[i] * 3;
            }
            checksum %= 10;
            checksum = checksum > 0 ? 10 - checksum : 0;

            newIsbn = newIsbn.Substring(0, newIsbn.Length - 1) + checksum.ToString();

            return new ISBN13(newIsbn);
        }

        public static ISBN10 From(ISBN13 isbn)
        {
            if (isbn.Value.StartsWith("979-"))
                throw new FormatException("ISBN-13 starting from 979 cannot be converted into ISBN-10.");

            string newIsbn = isbn.Value.Substring(4, isbn.Value.Length - 4);

            var clearIsbn = Regex.Replace(newIsbn, "-", "");

            var digits = clearIsbn
                .Select(x => int.Parse(x.ToString()))
                .ToArray();

            int checksum = 0;
            for (int i = 0; i < 9; i++)
            {
                checksum += (i+1) * digits[i];
            }
            checksum %= 11;

            newIsbn = newIsbn[0..^1] + (checksum == 10 ? "X" : checksum.ToString());
            return new ISBN10(newIsbn); ;
        }
    }
}
