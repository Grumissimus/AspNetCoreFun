using Boekje.Domain.Mappers;
using Boekje.Domain.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Boekje.Domain.Factories
{
    public static class ISBNFactory
    {
        public static ISBN Create(string isbn)
        {
            var clearIsbn = isbn?.Replace("-", "") ?? "";

            return clearIsbn?.Length switch
            {
                10 => ISBNMapper.From(new ISBN10(isbn)),
                13 => new ISBN13(isbn),
                _ => throw new FormatException($"The passed ISBN has incorrect format. Expected 10 or 13 digits, but got only {clearIsbn.Length}"),
            };
        }
    }
}
