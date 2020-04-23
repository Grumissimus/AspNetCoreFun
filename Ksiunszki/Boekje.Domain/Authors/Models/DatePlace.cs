using Boekje.Domain.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boekje.Domain.Authors.Models
{
    public class DatePlace : ValueObject
    {
        public DateTime Day { get; }
        public string Place { get; }

        public DatePlace(DateTime day, string place)
        {
            Day = day;
            Place = place;
        }

        public DatePlace(DatePlace dateplace)
        {
            Day = dateplace.Day;
            Place = dateplace.Place;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Day;
            yield return Place;
        }
    }
}
